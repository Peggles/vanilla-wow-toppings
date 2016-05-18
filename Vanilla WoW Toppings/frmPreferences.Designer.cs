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
            this.txtGameDataPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseGameDataPath = new System.Windows.Forms.Button();
            this.grbBackup = new System.Windows.Forms.GroupBox();
            this.btnBrowseBackupStoragePath = new System.Windows.Forms.Button();
            this.txtBackupStoragePath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseAddonLibraryPath = new System.Windows.Forms.Button();
            this.txtAddonLibraryPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemoveRealm = new System.Windows.Forms.Button();
            this.cbRealmlists = new System.Windows.Forms.ComboBox();
            this.btnAddRealm = new System.Windows.Forms.Button();
            this.numMaxStoredBackups = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grbBackup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStoredBackups)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 454);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(153, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Update settings";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtGameDataPath
            // 
            this.txtGameDataPath.Location = new System.Drawing.Point(9, 39);
            this.txtGameDataPath.Name = "txtGameDataPath";
            this.txtGameDataPath.Size = new System.Drawing.Size(470, 20);
            this.txtGameDataPath.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowseGameDataPath);
            this.groupBox1.Controls.Add(this.txtGameDataPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WoW game data";
            // 
            // btnBrowseGameDataPath
            // 
            this.btnBrowseGameDataPath.Location = new System.Drawing.Point(482, 37);
            this.btnBrowseGameDataPath.Name = "btnBrowseGameDataPath";
            this.btnBrowseGameDataPath.Size = new System.Drawing.Size(62, 23);
            this.btnBrowseGameDataPath.TabIndex = 1;
            this.btnBrowseGameDataPath.Text = "...";
            this.btnBrowseGameDataPath.UseVisualStyleBackColor = true;
            this.btnBrowseGameDataPath.Click += new System.EventHandler(this.btnBrowseWowFolder_Click);
            // 
            // grbBackup
            // 
            this.grbBackup.Controls.Add(this.label5);
            this.grbBackup.Controls.Add(this.label4);
            this.grbBackup.Controls.Add(this.label1);
            this.grbBackup.Controls.Add(this.numMaxStoredBackups);
            this.grbBackup.Controls.Add(this.btnBrowseBackupStoragePath);
            this.grbBackup.Controls.Add(this.txtBackupStoragePath);
            this.grbBackup.Location = new System.Drawing.Point(12, 199);
            this.grbBackup.Name = "grbBackup";
            this.grbBackup.Size = new System.Drawing.Size(550, 124);
            this.grbBackup.TabIndex = 2;
            this.grbBackup.TabStop = false;
            this.grbBackup.Text = "Backup-storage";
            // 
            // btnBrowseBackupStoragePath
            // 
            this.btnBrowseBackupStoragePath.Location = new System.Drawing.Point(482, 38);
            this.btnBrowseBackupStoragePath.Name = "btnBrowseBackupStoragePath";
            this.btnBrowseBackupStoragePath.Size = new System.Drawing.Size(62, 23);
            this.btnBrowseBackupStoragePath.TabIndex = 1;
            this.btnBrowseBackupStoragePath.Text = "...";
            this.btnBrowseBackupStoragePath.UseVisualStyleBackColor = true;
            this.btnBrowseBackupStoragePath.Click += new System.EventHandler(this.btnBrowseBackupFolder_Click);
            // 
            // txtBackupStoragePath
            // 
            this.txtBackupStoragePath.Location = new System.Drawing.Point(9, 40);
            this.txtBackupStoragePath.Name = "txtBackupStoragePath";
            this.txtBackupStoragePath.Size = new System.Drawing.Size(470, 20);
            this.txtBackupStoragePath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBrowseAddonLibraryPath);
            this.groupBox2.Controls.Add(this.txtAddonLibraryPath);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AddOn library";
            // 
            // btnBrowseAddonLibraryPath
            // 
            this.btnBrowseAddonLibraryPath.Location = new System.Drawing.Point(482, 36);
            this.btnBrowseAddonLibraryPath.Name = "btnBrowseAddonLibraryPath";
            this.btnBrowseAddonLibraryPath.Size = new System.Drawing.Size(62, 23);
            this.btnBrowseAddonLibraryPath.TabIndex = 1;
            this.btnBrowseAddonLibraryPath.Text = "...";
            this.btnBrowseAddonLibraryPath.UseVisualStyleBackColor = true;
            this.btnBrowseAddonLibraryPath.Click += new System.EventHandler(this.btnBrowseAddonsFolder_Click);
            // 
            // txtAddonLibraryPath
            // 
            this.txtAddonLibraryPath.Location = new System.Drawing.Point(9, 38);
            this.txtAddonLibraryPath.Name = "txtAddonLibraryPath";
            this.txtAddonLibraryPath.Size = new System.Drawing.Size(470, 20);
            this.txtAddonLibraryPath.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnRemoveRealm);
            this.groupBox3.Controls.Add(this.cbRealmlists);
            this.groupBox3.Controls.Add(this.btnAddRealm);
            this.groupBox3.Location = new System.Drawing.Point(12, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 74);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Realmlist";
            // 
            // btnRemoveRealm
            // 
            this.btnRemoveRealm.Location = new System.Drawing.Point(513, 38);
            this.btnRemoveRealm.Name = "btnRemoveRealm";
            this.btnRemoveRealm.Size = new System.Drawing.Size(31, 23);
            this.btnRemoveRealm.TabIndex = 2;
            this.btnRemoveRealm.Text = "-";
            this.btnRemoveRealm.UseVisualStyleBackColor = true;
            this.btnRemoveRealm.Click += new System.EventHandler(this.btnRemoveRealm_Click);
            // 
            // cbRealmlists
            // 
            this.cbRealmlists.FormattingEnabled = true;
            this.cbRealmlists.Location = new System.Drawing.Point(9, 40);
            this.cbRealmlists.Name = "cbRealmlists";
            this.cbRealmlists.Size = new System.Drawing.Size(470, 21);
            this.cbRealmlists.TabIndex = 0;
            // 
            // btnAddRealm
            // 
            this.btnAddRealm.Location = new System.Drawing.Point(482, 38);
            this.btnAddRealm.Name = "btnAddRealm";
            this.btnAddRealm.Size = new System.Drawing.Size(31, 23);
            this.btnAddRealm.TabIndex = 1;
            this.btnAddRealm.Text = "+";
            this.btnAddRealm.UseVisualStyleBackColor = true;
            this.btnAddRealm.Click += new System.EventHandler(this.btnAddRealm_Click);
            // 
            // numMaxStoredBackups
            // 
            this.numMaxStoredBackups.Location = new System.Drawing.Point(118, 94);
            this.numMaxStoredBackups.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxStoredBackups.Name = "numMaxStoredBackups";
            this.numMaxStoredBackups.Size = new System.Drawing.Size(44, 20);
            this.numMaxStoredBackups.TabIndex = 2;
            this.numMaxStoredBackups.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max stored backups:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set the path to the WoW client directory.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Set the path to your downloaded collection of AddOns.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Set the path to the directory where your backups will be stored.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Limit the number of stored backups.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(461, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Set the realm you want the client to connect to. You may store multiple realms fo" +
    "r easy switching.";
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 488);
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
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStoredBackups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtGameDataPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseGameDataPath;
        private System.Windows.Forms.GroupBox grbBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseAddonLibraryPath;
        private System.Windows.Forms.TextBox txtAddonLibraryPath;
        private System.Windows.Forms.Button btnBrowseBackupStoragePath;
        private System.Windows.Forms.TextBox txtBackupStoragePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRemoveRealm;
        private System.Windows.Forms.ComboBox cbRealmlists;
        private System.Windows.Forms.Button btnAddRealm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMaxStoredBackups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}