namespace DataCenterChanger
{
    partial class DCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCC));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpenFD = new MetroFramework.Controls.MetroButton();
            this.centreName = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.switchServer = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(23, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(187, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "GameSettings.ini File";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(28, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(638, 22);
            this.textBox1.TabIndex = 1;
            // 
            // OpenFD
            // 
            this.OpenFD.Location = new System.Drawing.Point(689, 130);
            this.OpenFD.Name = "OpenFD";
            this.OpenFD.Size = new System.Drawing.Size(75, 23);
            this.OpenFD.Style = MetroFramework.MetroColorStyle.Red;
            this.OpenFD.TabIndex = 2;
            this.OpenFD.Text = "Choose...";
            this.OpenFD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OpenFD.UseSelectable = true;
            this.OpenFD.Click += new System.EventHandler(this.OpenFD_Click);
            // 
            // centreName
            // 
            this.centreName.AutoCompleteCustomSource.AddRange(new string[] {
            "seas",
            "eus",
            "cus",
            "scus",
            "wus",
            "sbr",
            "neu",
            "weu",
            "eas",
            "eau",
            "wja"});
            this.centreName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.centreName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.centreName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.centreName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.centreName.ForeColor = System.Drawing.Color.White;
            this.centreName.Location = new System.Drawing.Point(28, 207);
            this.centreName.Name = "centreName";
            this.centreName.Size = new System.Drawing.Size(100, 22);
            this.centreName.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(23, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Server Name";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // switchServer
            // 
            this.switchServer.Location = new System.Drawing.Point(148, 207);
            this.switchServer.Name = "switchServer";
            this.switchServer.Size = new System.Drawing.Size(92, 22);
            this.switchServer.Style = MetroFramework.MetroColorStyle.White;
            this.switchServer.TabIndex = 7;
            this.switchServer.Text = "Switch";
            this.switchServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.switchServer.UseSelectable = true;
            this.switchServer.Click += new System.EventHandler(this.SwitchServer_Click);
            // 
            // DCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.switchServer);
            this.Controls.Add(this.centreName);
            this.Controls.Add(this.OpenFD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DCC";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Rainbow Six Siege - Server Switch";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroButton OpenFD;
        private System.Windows.Forms.TextBox centreName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton switchServer;
    }
}

