using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace borderlessCSharp
{
	class procInfo
	{
		private Dictionary<string, string> infoDict = new Dictionary<string, string>();

		public procInfo()
		{
			infoDict.Add("Process", "");
			infoDict.Add("PId", "");
			infoDict.Add("WndName", "");
			infoDict.Add("X", "");
			infoDict.Add("Y", "");
			infoDict.Add("Height", "");
			infoDict.Add("Width", "");
			infoDict.Add("Error", "");
		}
		public procInfo(string ProcessName, string ProcessId, string WindowName = "", string TopLeftX = "", string TopLeftY = "", string Height = "", string Width = "")
		{
			infoDict.Add("Process", ProcessName);
			infoDict.Add("PId", ProcessId);
			infoDict.Add("WndName", WindowName);
			infoDict.Add("X", TopLeftX);
			infoDict.Add("Y", TopLeftY);
			infoDict.Add("Height", Height);
			infoDict.Add("Width", Width);
			infoDict.Add("Error", "");
		}

		public void reSet(string ProcessName, string ProcessId, string WindowName = "", string TopLeftX = "", string TopLeftY = "", string Height = "", string Width = "")
		{
			infoDict["Process"] = ProcessName;
			infoDict["PId"] = ProcessId;
			infoDict["WndName"] = WindowName;
			infoDict["X"] = TopLeftX;
			infoDict["Y"] = TopLeftY;
			infoDict["Height"] = Height;
			infoDict["Width"] = Width;
			infoDict["Error"] = "";
		}

		public string getValue(string key)
		{
			if(infoDict.Keys.Contains(key))
			{
				return (infoDict[key]);
			}

			return ("");
		}

		public void setFromString(string ProcessName, string ProcessId, string infoString)
		{
			this.reSet(ProcessName, ProcessId);
			string[] infos = infoString.Split('|'); // example pRetVal: "WndName|10|20|100|120" - Errors are "!No Window Handle Found!", "Could not get Rect infos."
			switch (infos.Length)
			{
				case 1:
					if (infos[0] == "!No Window Handle Found!")
					{
						this.infoDict["Error"] = "No Window";
					}
					else if (infos[0] == "Could not get Rect infos.")
					{
						this.infoDict["Error"] = "No Rect infos";
					}
					else
					{
						this.infoDict["WndName"] = infos[0];
					}
					break;
				case 2:
					this.infoDict["WndName"] = infos[0];
					this.infoDict["X"] = infos[1];
					break;
				case 3:
					this.infoDict["WndName"] = infos[0];
					this.infoDict["X"] = infos[1];
					this.infoDict["Y"] = infos[2];
					break;
				case 4:
					this.infoDict["WndName"] = infos[0];
					this.infoDict["X"] = infos[1];
					this.infoDict["Y"] = infos[2];
					this.infoDict["Height"] = infos[3];
					break;
				case 5:
					this.infoDict["WndName"] = infos[0];
					this.infoDict["X"] = infos[1];
					this.infoDict["Y"] = infos[2];
					this.infoDict["Height"] = infos[3];
					this.infoDict["Width"] = infos[4];
					break;
				default:
					// Consider this a debug case - should not be reachable if everything prior was done accordingly.
					throw new System.Exception("input infoString was either to long or to short.");
					break; // while currently unreachable, break stays so i don't forget it once i change the throw exception bit.
			}
		}

		public List<string> getInfo()
		{
			List<string> infoList = new List<string>();

			foreach (string key in infoDict.Keys)
			{
				if (key == "Error")
				{
					continue;
				}
				if (String.IsNullOrEmpty(infoDict[key]))
				{
					this.infoDict["Error"] = "Incomplete Information";
				}
				else
				{
					infoList.Add($"{key}: {infoDict[key]}");
				}
			}

			return (infoList);
		}

		public bool isError()
		{
			return (!String.IsNullOrEmpty(this.infoDict["Error"]));
		}

		public string getCurrentError()
		{
			return (this.infoDict["Error"]);
		}
	}
}
