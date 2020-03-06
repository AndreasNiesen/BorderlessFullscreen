namespace borderlessCSharp
{
	partial class noShowListForm
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
			this.noShowListBox = new System.Windows.Forms.ListBox();
			this.removeFromBlacklistButton = new System.Windows.Forms.Button();
			this.okButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// noShowListBox
			// 
			this.noShowListBox.BackColor = System.Drawing.Color.Silver;
			this.noShowListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.noShowListBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noShowListBox.FormattingEnabled = true;
			this.noShowListBox.IntegralHeight = false;
			this.noShowListBox.ItemHeight = 23;
			this.noShowListBox.Location = new System.Drawing.Point(17, 12);
			this.noShowListBox.Name = "noShowListBox";
			this.noShowListBox.Size = new System.Drawing.Size(257, 277);
			this.noShowListBox.TabIndex = 3;
			// 
			// removeFromBlacklistButton
			// 
			this.removeFromBlacklistButton.BackColor = System.Drawing.Color.Silver;
			this.removeFromBlacklistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.removeFromBlacklistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.removeFromBlacklistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeFromBlacklistButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeFromBlacklistButton.Location = new System.Drawing.Point(16, 310);
			this.removeFromBlacklistButton.Name = "removeFromBlacklistButton";
			this.removeFromBlacklistButton.Size = new System.Drawing.Size(126, 70);
			this.removeFromBlacklistButton.TabIndex = 10;
			this.removeFromBlacklistButton.Text = "Remove from NoShowList";
			this.removeFromBlacklistButton.UseVisualStyleBackColor = false;
			this.removeFromBlacklistButton.Click += new System.EventHandler(this.removeFromBlacklistButton_Click);
			// 
			// okButton
			// 
			this.okButton.BackColor = System.Drawing.Color.Silver;
			this.okButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.okButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
			this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.okButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okButton.Location = new System.Drawing.Point(148, 310);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(126, 70);
			this.okButton.TabIndex = 11;
			this.okButton.Text = "Ok!";
			this.okButton.UseVisualStyleBackColor = false;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// noShowListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(291, 410);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.removeFromBlacklistButton);
			this.Controls.Add(this.noShowListBox);
			this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "noShowListForm";
			this.Text = "NoShow List";
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.ListBox noShowListBox;
        private System.Windows.Forms.Button removeFromBlacklistButton;
        private System.Windows.Forms.Button okButton;
    }
}