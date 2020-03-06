namespace borderlessCSharp
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.mainLabel = new System.Windows.Forms.Label();
			this.allProcessesListBox = new System.Windows.Forms.ListBox();
			this.processInfoListBox = new System.Windows.Forms.ListBox();
			this.allProcessesLabel = new System.Windows.Forms.Label();
			this.processInfoLabel = new System.Windows.Forms.Label();
			this.startBorderlessingButton = new System.Windows.Forms.Button();
			this.addToBlacklistButton = new System.Windows.Forms.Button();
			this.showNoShowListButton = new System.Windows.Forms.Button();
			this.refreshListButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainLabel.Location = new System.Drawing.Point(196, 9);
			this.mainLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(244, 36);
			this.mainLabel.TabIndex = 0;
			this.mainLabel.Text = "Borderless Window";
			// 
			// allProcessesListBox
			// 
			this.allProcessesListBox.BackColor = System.Drawing.Color.Silver;
			this.allProcessesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.allProcessesListBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allProcessesListBox.FormattingEnabled = true;
			this.allProcessesListBox.HorizontalScrollbar = true;
			this.allProcessesListBox.IntegralHeight = false;
			this.allProcessesListBox.ItemHeight = 23;
			this.allProcessesListBox.Location = new System.Drawing.Point(40, 108);
			this.allProcessesListBox.Name = "allProcessesListBox";
			this.allProcessesListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.allProcessesListBox.Size = new System.Drawing.Size(250, 219);
			this.allProcessesListBox.TabIndex = 1;
			this.allProcessesListBox.Click += new System.EventHandler(this.allProcessesListBox_Click);
			// 
			// processInfoListBox
			// 
			this.processInfoListBox.BackColor = System.Drawing.Color.Silver;
			this.processInfoListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.processInfoListBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.processInfoListBox.FormattingEnabled = true;
			this.processInfoListBox.HorizontalScrollbar = true;
			this.processInfoListBox.IntegralHeight = false;
			this.processInfoListBox.ItemHeight = 23;
			this.processInfoListBox.Location = new System.Drawing.Point(353, 108);
			this.processInfoListBox.Name = "processInfoListBox";
			this.processInfoListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.processInfoListBox.Size = new System.Drawing.Size(250, 219);
			this.processInfoListBox.TabIndex = 2;
			// 
			// allProcessesLabel
			// 
			this.allProcessesLabel.AutoSize = true;
			this.allProcessesLabel.BackColor = System.Drawing.Color.DimGray;
			this.allProcessesLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.allProcessesLabel.Location = new System.Drawing.Point(105, 67);
			this.allProcessesLabel.Name = "allProcessesLabel";
			this.allProcessesLabel.Size = new System.Drawing.Size(121, 26);
			this.allProcessesLabel.TabIndex = 4;
			this.allProcessesLabel.Text = "All Processes";
			// 
			// processInfoLabel
			// 
			this.processInfoLabel.AutoSize = true;
			this.processInfoLabel.BackColor = System.Drawing.Color.DimGray;
			this.processInfoLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.processInfoLabel.Location = new System.Drawing.Point(411, 67);
			this.processInfoLabel.Name = "processInfoLabel";
			this.processInfoLabel.Size = new System.Drawing.Size(122, 26);
			this.processInfoLabel.TabIndex = 5;
			this.processInfoLabel.Text = "Selected Info";
			// 
			// startBorderlessingButton
			// 
			this.startBorderlessingButton.BackColor = System.Drawing.Color.Silver;
			this.startBorderlessingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.startBorderlessingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.startBorderlessingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startBorderlessingButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startBorderlessingButton.Location = new System.Drawing.Point(353, 333);
			this.startBorderlessingButton.Name = "startBorderlessingButton";
			this.startBorderlessingButton.Size = new System.Drawing.Size(100, 70);
			this.startBorderlessingButton.TabIndex = 6;
			this.startBorderlessingButton.Text = "Remove Border";
			this.startBorderlessingButton.UseVisualStyleBackColor = false;
			this.startBorderlessingButton.Click += new System.EventHandler(this.startBorderlessingButton_Click);
			// 
			// addToBlacklistButton
			// 
			this.addToBlacklistButton.BackColor = System.Drawing.Color.Silver;
			this.addToBlacklistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.addToBlacklistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.addToBlacklistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addToBlacklistButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addToBlacklistButton.Location = new System.Drawing.Point(459, 333);
			this.addToBlacklistButton.Name = "addToBlacklistButton";
			this.addToBlacklistButton.Size = new System.Drawing.Size(144, 70);
			this.addToBlacklistButton.TabIndex = 9;
			this.addToBlacklistButton.Text = "Add Process to NoShow List";
			this.addToBlacklistButton.UseVisualStyleBackColor = false;
			this.addToBlacklistButton.Click += new System.EventHandler(this.addToBlacklistButton_Click);
			// 
			// showNoShowListButton
			// 
			this.showNoShowListButton.BackColor = System.Drawing.Color.Silver;
			this.showNoShowListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.showNoShowListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.showNoShowListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.showNoShowListButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.showNoShowListButton.Location = new System.Drawing.Point(146, 333);
			this.showNoShowListButton.Name = "showNoShowListButton";
			this.showNoShowListButton.Size = new System.Drawing.Size(144, 70);
			this.showNoShowListButton.TabIndex = 10;
			this.showNoShowListButton.Text = "Show NoShow List";
			this.showNoShowListButton.UseVisualStyleBackColor = false;
			this.showNoShowListButton.Click += new System.EventHandler(this.showNoShowListButton_Click);
			// 
			// refreshListButton
			// 
			this.refreshListButton.BackColor = System.Drawing.Color.Silver;
			this.refreshListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.refreshListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.refreshListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.refreshListButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refreshListButton.Location = new System.Drawing.Point(40, 333);
			this.refreshListButton.Name = "refreshListButton";
			this.refreshListButton.Size = new System.Drawing.Size(100, 70);
			this.refreshListButton.TabIndex = 11;
			this.refreshListButton.Text = "Refresh Proc List";
			this.refreshListButton.UseVisualStyleBackColor = false;
			this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
			// 
			// mainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(637, 429);
			this.Controls.Add(this.refreshListButton);
			this.Controls.Add(this.showNoShowListButton);
			this.Controls.Add(this.addToBlacklistButton);
			this.Controls.Add(this.startBorderlessingButton);
			this.Controls.Add(this.processInfoLabel);
			this.Controls.Add(this.allProcessesLabel);
			this.Controls.Add(this.processInfoListBox);
			this.Controls.Add(this.allProcessesListBox);
			this.Controls.Add(this.mainLabel);
			this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "mainForm";
			this.Text = "BorderlessFullscreen";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.ListBox allProcessesListBox;
        private System.Windows.Forms.ListBox processInfoListBox;
        private System.Windows.Forms.Label allProcessesLabel;
        private System.Windows.Forms.Label processInfoLabel;
        private System.Windows.Forms.Button startBorderlessingButton;
        private System.Windows.Forms.Button addToBlacklistButton;
        private System.Windows.Forms.Button showNoShowListButton;
		private System.Windows.Forms.Button refreshListButton;
	}
}

