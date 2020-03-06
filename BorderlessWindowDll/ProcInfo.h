#pragma once

#include <Windows.h>
#include <TlHelp32.h>
#include <string>

extern "C"
{
	__declspec(dllimport) bool bNextProcEntry(int* pLastPid, wchar_t* pNext, int iNextMaxLen);
	__declspec(dllimport) int iProcWinInfos(int iPid, wchar_t* pRetVal, int iMaxLen);
	__declspec(dllimport) bool bRemoveBorder(wchar_t* pWndName, int width, int height);
}

struct params
{
	public:
	unsigned long ulPid;
	HWND hWnd;
	params(unsigned long in_ulPid, HWND in_hWnd): ulPid(in_ulPid), hWnd(in_hWnd) {}
};

BOOL CALLBACK bEnumWinProc(HWND hWnd, LPARAM lparam);