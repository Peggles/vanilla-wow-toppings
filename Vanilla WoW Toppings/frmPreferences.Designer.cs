namespace Vanilla_WoW_Toppings
{
    partial class frmPreferences
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtWowFolder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseWowFolder = new System.Windows.Forms.Button();
            this.grbBackup = new System.Windows.Forms.GroupBox();
            this.btnBrowseBackupFolder = new System.Windows.Forms.Button();
            this.txtBackupFolder = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseAddonsFolder = new System.Windows.Forms.Button();
            this.txtAddonsFolder = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveRealm = new System.Windows.Forms.Button();
            this.cbRealmlists = new System.Windows.Forms.ComboBox();
            this.btnAddRealm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grbBackup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 336);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(134, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtWowFolder
            // 
            this.txtWowFolder.Location = new System.Drawing.Point(9, 19);
            this.txtWowFolder.Name = "txtWowFolder";
            this.txtWowFolder.Size = new System.Drawing.Size(470, 20);
            this.txtWowFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseWowFolder);
            this.groupBox1.Controls.Add(this.txtWowFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Installed WoW game directory";
            // 
            // btnBrowseWowFolder
            // 
            this.btnBrowseWowFolder.Location = new System.Drawing.Point(482, 17);
            this.btnBrowseWowFolder.Name = "btnBrowseWowFolder";
            this.btnBrowseWowFolder.Size = new System.Drawing.Size(62, 23);
            this.btnBrowseWowFolder.TabIndex = 1;
            this.btnBrowseWowFolder.Text = "...";
            this.btnBrowseWowFolder.UseVisualStyleBackColor = true;
            this.btnBrowseWowFolder.Click += new System.EventHandler(this.btnBrowseWowFolder_Click);
            // 
            // grbBackup
            // 
            this.grbBackup.Controls.Add(this.btnBrowseBackupFolder);
            this.grbBackup.Controls.Add(this.txtBackupFolder);
            this.grbBackup.Location = new System.Drawing.Point(12, 169);
            this.grbBackup.Name = "grbBackup";
            this.grbBackup.Size = new System.Drawing.Size(550, 54);
            this.grbBackup.TabIndex = 2;
            this.grbBackup.TabStop = false;
            this.grbBackup.Text = "Backup directory";
            // 
            // btnBrowseBackupFolder
            // 
            this.btnBrowseBackupFolder.Location = new System.Drawing.Point(482, 17);
            this.btnBrowseBackupFolder.Name = "btnBrowseBackupFolder";
            this.btnBrowseBackupFolder.Size = new System.Drawing.Size(62, 23);
            this.btnBrowseBackupFolder.TabIndex = 1;
            this.btnBrowseBackupFolder.Text = "...";
            this.btnBrowseBackupFolder.UseVisualStyleBackColor = true;
            this.btnBrowseBackupFolder.Click += new System.EventHandler(this.btnBrowseBackupFolder_Click);
            // 
            // txtBackupFolder
            // 
            this.txtBackupFolder.Location = new System.Drawing.Point(9, 19);
            this.txtBackupFolder.Name = "txtBackupFolder";
            this.txtBackupFolder.Size = new System.Drawing.Size(470, 20);
            this.txtBackupFolder.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowseAddonsFolder);
            this.groupBox2.Controls.Add(this.txtAddonsFolder);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AddOn library directory";
            // 
            // btnBrowseAddonsFolder
            // 
            this.btnBrowseAddonsFolder.Location = new System.Drawing.Point(481, 16);
            this.btnBrowseAddonsFolder.Name = "btnBrowseAddonsFolder";
            this.btnBrowseAddonsFolder.Size = new System.Drawing.Size(62, 23);
            this.btnBrowseAddonsFolder.TabIndex = 1;
            this.btnBrowseAddonsFolder.Text = "...";
            this.btnBrowseAddonsFolder.UseVisualStyleBackColor = true;
            this.btnBrowseAddonsFolder.Click += new System.EventHandler(this.btnBrowseAddonsFolder_Click);
            // 
            // txtAddonsFolder
            // 
            this.txtAddonsFolder.Location = new System.Drawing.Point(8, 19);
            this.txtAddonsFolder.Name = "txtAddonsFolder";
            this.txtAddonsFolder.Size = new System.Drawing.Size(470, 20);
            this.txtAddonsFolder.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRemoveRealm);
            this.groupBox3.Controls.Add(this.cbRealmlists);
            this.groupBox3.Controls.Add(this.btnAddRealm);
            this.groupBox3.Location = new System.Drawing.Point(12, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 54);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Realmlist";
            // 
            // btnRemoveRealm
            // 
            this.btnRemoveRealm.Location = new System.Drawing.Point(513, 17);
            this.btnRemoveRealm.Name = "btnRemoveRealm";
            this.btnRemoveRealm.Size = new System.Drawing.Size(31, 23);
            this.btnRemoveRealm.TabIndex = 3;
            this.btnRemoveRealm.Text = "-";
            this.btnRemoveRealm.UseVisualStyleBackColor = true;
            this.btnRemoveRealm.Click += new System.EventHandler(this.btnRemoveRealm_Click);
            // 
            // cbRealmlists
            // 
            this.cbRealmlists.FormattingEnabled = true;
            this.cbRealmlists.Location = new System.Drawing.Point(9, 19);
            this.cbRealmlists.Name = "cbRealmlists";
            this.cbRealmlists.Size = new System.Drawing.Size(470, 21);
            this.cbRealmlists.TabIndex = 2;
            // 
            // btnAddRealm
            // 
            this.btnAddRealm.Location = new System.Drawing.Point(482, 17);
            this.btnAddRealm.Name = "btnAddRealm";
            this.btnAddRealm.Size = new System.Drawing.Size(31, 23);
            this.btnAddRealm.TabIndex = 1;
            this.btnAddRealm.Text = "+";
            this.btnAddRealm.UseVisualStyleBackColor = true;
            this.btnAddRealm.Click += new System.EventHandler(this.btnAddRealm_Click);
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 373);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbBackup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPreferences";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbBackup.ResumeLayout(false);
            this.grbBackup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtWowFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseWowFolder;
        private System.Windows.Forms.GroupBox grbBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseAddonsFolder;
        private System.Windows.Forms.TextBox txtAddonsFolder;
        private System.Windows.Forms.Button btnBrowseBackupFolder;
        private System.Windows.Forms.TextBox txtBackupFolder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveRealm;
        private System.Windows.Forms.ComboBox cbRealmlists;
        private System.Windows.Forms.Button btnAddRealm;
    }
}