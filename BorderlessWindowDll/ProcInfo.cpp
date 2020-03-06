#include "ProcInfo.h"

bool bNextProcEntry(int* pLastPid, wchar_t* pNext, int iNextMaxLen)
{
	HANDLE hSnap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, NULL);
	PROCESSENTRY32W peEntry;
	peEntry.dwSize = sizeof(PROCESSENTRY32W);

	if(!Process32FirstW(hSnap, &peEntry))
	{
		CloseHandle(hSnap);
		return(FALSE);
	}

	if(*pLastPid < 0)
	{
		if(iNextMaxLen > wcslen(peEntry.szExeFile))
			wcscpy_s(pNext, iNextMaxLen, peEntry.szExeFile);
		else
			wcsncpy_s(pNext, iNextMaxLen, peEntry.szExeFile, iNextMaxLen - 1);
		*pLastPid = peEntry.th32ProcessID;
		CloseHandle(hSnap);
		return(TRUE);
	}

	do
	{
		if(*pLastPid == peEntry.th32ProcessID)
		{
			if(Process32NextW(hSnap, &peEntry))
			{
				if(iNextMaxLen > wcslen(peEntry.szExeFile))
					wcscpy_s(pNext, iNextMaxLen, peEntry.szExeFile);
				else
					wcsncpy_s(pNext, iNextMaxLen, peEntry.szExeFile, iNextMaxLen - 1);
				*pLastPid = peEntry.th32ProcessID;
				CloseHandle(hSnap);
				return(TRUE);
			}
			else
			{
				CloseHandle(hSnap);
				return(FALSE);
			}
		}
	} while(Process32NextW(hSnap, &peEntry));

	return(FALSE);
}

BOOL CALLBACK bEnumWinProc(HWND hWnd, LPARAM lparam)
{
	params* toFill = reinterpret_cast<params *>(lparam);
	unsigned long ulPid = -1;
	GetWindowThreadProcessId(hWnd, &ulPid);
	if(toFill->ulPid == ulPid && IsWindowVisible(hWnd))
	{
		toFill->hWnd = hWnd;
		return(FALSE);
	}
	return(TRUE);
}

int iProcWinInfos(int iPid, wchar_t* pRetVal, int iMaxLen)
{
	// TODO - add getlasterror infos

	if(iMaxLen < 50) // 50 chars should fit atleast every error message.
	{
		wcsncpy_s(pRetVal, iMaxLen, L"\0", _TRUNCATE); // returns only empty, if iMaxLen too small
		return(-1);
	}

	params wndInfo(iPid, NULL);
	EnumWindows(bEnumWinProc, reinterpret_cast<LPARAM>(&wndInfo));
	if(wndInfo.hWnd == NULL)
	{
		wcsncpy_s(pRetVal, iMaxLen, L"!No Window Handle Found!", _TRUNCATE);
		return(0);	// TODO - Differentiate between "No Visible Window" and Error - For now = no visible window, therefore no error
	}

	std::wstring toRet = L"";
	std::wstring splitter = L"|"; // splits up the different infos
	int iWndTxtLen = GetWindowTextLengthW(wndInfo.hWnd)+1;
	if(iWndTxtLen == 0)
	{
		toRet += L"[empty]"; // standin for titleless window
	}
	else
	{
		wchar_t* pWndTitle = new wchar_t[iWndTxtLen];

		GetWindowTextW(wndInfo.hWnd, pWndTitle, iWndTxtLen);
		toRet += std::wstring(pWndTitle);

		delete[] pWndTitle;
	}
	toRet += splitter;

	RECT rectInfo;
	if(!GetWindowRect(wndInfo.hWnd, &rectInfo))
	{
		wcsncpy_s(pRetVal, iMaxLen, L"Could not get Rect infos.", _TRUNCATE);
		return(-1);
	}
	toRet += std::to_wstring(rectInfo.left) + splitter;
	toRet += std::to_wstring(rectInfo.top) + splitter;
	toRet += std::to_wstring(rectInfo.bottom - rectInfo.top) + splitter;
	toRet += std::to_wstring(rectInfo.right - rectInfo.left);

	wcsncpy_s(pRetVal, iMaxLen, toRet.c_str(), _TRUNCATE);
	if(iMaxLen < toRet.length())
		return(0);

	return(1);
}

bool bRemoveBorder(wchar_t* pWndName, int width, int height)
{
	HWND hWnd = FindWindowW(NULL, pWndName);
	if(hWnd == NULL)
		return(FALSE);

	LONG_PTR rmBorder = GetWindowLongPtrW(hWnd, GWL_STYLE);
	if(rmBorder == 0)
		return(FALSE);

	rmBorder &= ~WS_CAPTION;
	rmBorder &= ~WS_SYSMENU;
	rmBorder &= ~WS_SIZEBOX;

	if(!SetWindowLongPtrW(hWnd, GWL_STYLE, rmBorder))
		return(FALSE);

	if(SetWindowPos(hWnd, HWND_NOTOPMOST, 0, 0, width, height, SWP_ASYNCWINDOWPOS | SWP_NOZORDER | SWP_FRAMECHANGED))
		return(FALSE);

	return(TRUE);
}