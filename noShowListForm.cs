using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borderlessCSharp
{
	public partial class noShowListForm : Form
	{
		public mainForm mForm;
		
		public noShowListForm(mainForm mFormIn)
		{
			InitializeComponent();
			mForm = mFormIn;
			refreshDataSource();
		}

		private void refreshDataSource()
		{
			noShowListBox.DataSource = null;	// TODO - try to find alternative
			noShowListBox.DataSource = mForm.blacklistedProcesses;
		}

        private void okButton_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void removeFromBlacklistButton_Click(object sender, EventArgs e)
        {
			string toRemove = (string)noShowListBox.SelectedItem;

			if (toRemove != null)
			{
				mForm.blacklistedProcesses.Remove(toRemove);
				refreshDataSource(); 
			}
        }
    }
}
