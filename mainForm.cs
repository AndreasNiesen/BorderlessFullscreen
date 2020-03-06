using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace borderlessCSharp
{
    public partial class mainForm : Form
    {
		public List<string> blacklistedProcesses = new List<string>();
		private List<string> currentProcesses = new List<string>();
		private List<string> wannaSleep = new List<string>();
		private Dictionary<string, string> procWndInfos = new Dictionary<string, string>();
		
		//--------------------------------------------------------------------------------------------------
		//__declspec(dllimport) bool bNextProcEntry(int* pLastPid, wchar_t* pNext, int iNextMaxLen);
		//__declspec(dllimport) int iProcWinInfos(int iPid, wchar_t* pRetVal, int iMaxLen);
		//__declspec(dllimport) bool bRemoveBorder(wchar_t* pWndName, int width, int height);
		//--------------------------------------------------------------------------------------------------

		[DllImport("BorderlessWindowDll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool bNextProcEntry(IntPtr pInt, IntPtr pChar, int iMaxLen);

		[DllImport("BorderlessWindowDll", CallingConvention = CallingConvention.Cdecl)]
		static extern int iProcWinInfos(int iPid, IntPtr pRetVal, int iMaxLen);

		[DllImport("BorderlessWindowDll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool bRemoveBorder(IntPtr pWndName, int width, int height);

		public mainForm()
        {
            InitializeComponent();
			if (System.IO.File.Exists(".\\blacklist.save"))
			{
				string[] buffer = System.IO.File.ReadAllLines(".\\blacklist.save");
				blacklistedProcesses = new List<string>(buffer);
			}
			updateProcessesList();
			procWndInfos.Add("Process", "");
			procWndInfos.Add("PId", "");
			procWndInfos.Add("WndName", "");
			procWndInfos.Add("X", "");
			procWndInfos.Add("Y", "");
			procWndInfos.Add("Height", "");
			procWndInfos.Add("Width", "");
		}

		public void updateProcessesList()
		{
			currentProcesses = updateCurrentProcesses();
			allProcessesListBox.DataSource = null;	// TODO - find better solution!
			allProcessesListBox.DataSource = currentProcesses;
		}

        private void showNoShowListButton_Click(object sender, EventArgs e)
        {
			noShowListForm noShowListWindow = new noShowListForm(this);
			noShowListWindow.ShowDialog();
			updateProcessesList();
        }

		private void addToBlacklistButton_Click(object sender, EventArgs e)
		{
			string toAdd = (string)allProcessesListBox.SelectedItem;
			toAdd = toAdd.Split(':')[0]; //TODO - check if process name can contain ':' - change if it can

			if (toAdd != null)
			{
				blacklistedProcesses.Add(toAdd);
				updateProcessesList();
			}
		}

		private List<string> updateCurrentProcesses()
		{
			List<string> retList = new List<string>();
			string buffer = "";
			int maxLen = 100;
			char[] nextProc = new char[maxLen];
			nextProc[0] = '\0';                 // Not sure if it auto sets array to null
			IntPtr pNextProc = Marshal.UnsafeAddrOfPinnedArrayElement(nextProc, 0);
			IntPtr pPid = Marshal.AllocHGlobal(sizeof(int));
			Marshal.WriteInt32(pPid, -1);
			
			while (bNextProcEntry(pPid, pNextProc, maxLen))
			{
				buffer = new string(nextProc).Split('\0')[0];
				if (!blacklistedProcesses.Contains(buffer))
				{
					buffer += $": {Marshal.ReadInt32(pPid)}";
					retList.Add(buffer);
				}
			}

			return (retList);
		}

		private void refreshListButton_Click(object sender, EventArgs e)
		{
			processInfoListBox.DataSource = null;
			updateProcessesList();
		}

		private void allProcessesListBox_Click(object sender, EventArgs e)
		{
			if (allProcessesListBox.SelectedItem != null)
			{
				string pidSubStr = (string)allProcessesListBox.SelectedItem;
				int buffer = pidSubStr.LastIndexOf(':');
				string procName = pidSubStr.Substring(0, buffer);
				buffer += 2;
				pidSubStr = pidSubStr.Substring(buffer);
				int iPid = int.Parse(pidSubStr);
				int maxLen = 1000;
				char[] retVal = new char[maxLen];
				IntPtr pRetVal = Marshal.UnsafeAddrOfPinnedArrayElement(retVal, 0);

				buffer = iProcWinInfos(iPid, pRetVal, maxLen);
				string infos = new string(retVal).Split('\0')[0];

				wannaSleep.Clear();

				if (buffer < 0)
				{
					wannaSleep.Add(infos);
				}
				else if (buffer == 0)
				{
					if (infos != "!No Window Handle Found!")
					{
						wannaSleep.Add("Information incomplete.");
						wannaSleep.Add("Please increase the length of your buffer.");
					}
					else
					{
						wannaSleep.Add(infos);
						wannaSleep.Add("");
						wannaSleep.Add("Recommendation:");
						wannaSleep.Add("    Add Process to NoShow List");
					}
				}
				else if (buffer > 0)
				{
					string[] splitInfos = infos.Split('|');
					procWndInfos["Process"] = procName;
					procWndInfos["PId"] = pidSubStr;
					procWndInfos["WndName"] = splitInfos[0];
					procWndInfos["X"] = splitInfos[1];
					procWndInfos["Y"] = splitInfos[2];
					procWndInfos["Height"] = splitInfos[3];
					procWndInfos["Width"] = splitInfos[4];

					foreach (string key in procWndInfos.Keys)
					{
						wannaSleep.Add($"{key}: {procWndInfos[key]}");
					}
				}

				processInfoListBox.DataSource = new List<string>();
				processInfoListBox.DataSource = wannaSleep;
			}
		}

		private void startBorderlessingButton_Click(object sender, EventArgs e)
		{
			if (allProcessesListBox.SelectedItem != null)
			{
				Rectangle myRect = Screen.FromControl(this).Bounds;
				IntPtr pWinName = Marshal.StringToHGlobalUni(procWndInfos["WndName"]);
				bRemoveBorder(pWinName, myRect.Width, myRect.Height);
				Marshal.FreeHGlobal(pWinName);
			}
		}

		private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			System.IO.File.WriteAllLines(".\\blacklist.save", blacklistedProcesses);
		}
	}
}
