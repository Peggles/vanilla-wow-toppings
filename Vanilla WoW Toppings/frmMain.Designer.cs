namespace Vanilla_WoW_Toppings
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPerformBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.miRestoreBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.directoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenGameDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenAddonLibraryDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenBackupDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.miLaunchWow = new System.Windows.Forms.ToolStripMenuItem();
            this.cbInstalledAddons = new System.Windows.Forms.ComboBox();
            this.grbInstalledAddons = new System.Windows.Forms.GroupBox();
            this.btnUninstallAddon = new System.Windows.Forms.Button();
            this.grbAddonLibrary = new System.Windows.Forms.GroupBox();
            this.btnInstallAddon = new System.Windows.Forms.Button();
            this.cbLibraryAddons = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.grbInstalledAddons.SuspendLayout();
            this.grbAddonLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoriesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.miLaunchWow});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(657, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPerformBackup,
            this.miRestoreBackup,
            this.toolStripSeparator1,
            this.miExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miPerformBackup
            // 
            this.miPerformBackup.Name = "miPerformBackup";
            this.miPerformBackup.Size = new System.Drawing.Size(159, 22);
            this.miPerformBackup.Text = "Perform backup";
            this.miPerformBackup.Click += new System.EventHandler(this.miPerformBackup_Click);
            // 
            // miRestoreBackup
            // 
            this.miRestoreBackup.Name = "miRestoreBackup";
            this.miRestoreBackup.Size = new System.Drawing.Size(159, 22);
            this.miRestoreBackup.Text = "Restore backup";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(159, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // directoriesToolStripMenuItem
            // 
            this.directoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenGameDirectory,
            this.miOpenAddonLibraryDirectory,
            this.miOpenBackupDirectory});
            this.directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            this.directoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.directoriesToolStripMenuItem.Text = "Directories";
            // 
            // miOpenGameDirectory
            // 
            this.miOpenGameDirectory.Name = "miOpenGameDirectory";
            this.miOpenGameDirectory.Size = new System.Drawing.Size(164, 22);
            this.miOpenGameDirectory.Text = "Game data...";
            this.miOpenGameDirectory.Click += new System.EventHandler(this.miOpenGameDirectory_Click);
            // 
            // miOpenAddonLibraryDirectory
            // 
            this.miOpenAddonLibraryDirectory.Name = "miOpenAddonLibraryDirectory";
            this.miOpenAddonLibraryDirectory.Size = new System.Drawing.Size(164, 22);
            this.miOpenAddonLibraryDirectory.Text = "AddOn library...";
            this.miOpenAddonLibraryDirectory.Click += new System.EventHandler(this.miOpenAddonLibraryDirectory_Click);
            // 
            // miOpenBackupDirectory
            // 
            this.miOpenBackupDirectory.Name = "miOpenBackupDirectory";
            this.miOpenBackupDirectory.Size = new System.Drawing.Size(164, 22);
            this.miOpenBackupDirectory.Text = "Backup storage...";
            this.miOpenBackupDirectory.Click += new System.EventHandler(this.miOpenBackupDirectory_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPreferences});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // miPreferences
            // 
            this.miPreferences.Name = "miPreferences";
            this.miPreferences.Size = new System.Drawing.Size(144, 22);
            this.miPreferences.Text = "Preferences...";
            this.miPreferences.Click += new System.EventHandler(this.miPreferences_Click);
            // 
            // miLaunchWow
            // 
            this.miLaunchWow.Name = "miLaunchWow";
            this.miLaunchWow.Size = new System.Drawing.Size(90, 20);
            this.miLaunchWow.Text = "Launch WoW";
            this.miLaunchWow.Click += new System.EventHandler(this.miLaunchWow_Click);
            // 
            // cbInstalledAddons
            // 
            this.cbInstalledAddons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbInstalledAddons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInstalledAddons.FormattingEnabled = true;
            this.cbInstalledAddons.IntegralHeight = false;
            this.cbInstalledAddons.ItemHeight = 34;
            this.cbInstalledAddons.Location = new System.Drawing.Point(16, 29);
            this.cbInstalledAddons.MaxDropDownItems = 15;
            this.cbInstalledAddons.Name = "cbInstalledAddons";
            this.cbInstalledAddons.Size = new System.Drawing.Size(600, 40);
            this.cbInstalledAddons.TabIndex = 0;
            this.cbInstalledAddons.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbInstalledAddons_DrawItem);
            // 
            // grbInstalledAddons
            // 
            this.grbInstalledAddons.Controls.Add(this.btnUninstallAddon);
            this.grbInstalledAddons.Controls.Add(this.cbInstalledAddons);
            this.grbInstalledAddons.Location = new System.Drawing.Point(12, 39);
            this.grbInstalledAddons.Name = "grbInstalledAddons";
            this.grbInstalledAddons.Size = new System.Drawing.Size(633, 137);
            this.grbInstalledAddons.TabIndex = 0;
            this.grbInstalledAddons.TabStop = false;
            this.grbInstalledAddons.Text = "Installed AddOns";
            // 
            // btnUninstallAddon
            // 
            this.btnUninstallAddon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstallAddon.Location = new System.Drawing.Point(16, 84);
            this.btnUninstallAddon.Name = "btnUninstallAddon";
            this.btnUninstallAddon.Size = new System.Drawing.Size(198, 39);
            this.btnUninstallAddon.TabIndex = 1;
            this.btnUninstallAddon.Text = "Uninstall";
            this.btnUninstallAddon.UseVisualStyleBackColor = true;
            this.btnUninstallAddon.Click += new System.EventHandler(this.btnUninstallAddon_Click);
            // 
            // grbAddonLibrary
            // 
            this.grbAddonLibrary.Controls.Add(this.btnInstallAddon);
            this.grbAddonLibrary.Controls.Add(this.cbLibraryAddons);
            this.grbAddonLibrary.Location = new System.Drawing.Point(12, 203);
            this.grbAddonLibrary.Name = "grbAddonLibrary";
            this.grbAddonLibrary.Size = new System.Drawing.Size(633, 142);
            this.grbAddonLibrary.TabIndex = 1;
            this.grbAddonLibrary.TabStop = false;
            this.grbAddonLibrary.Text = "AddOn Library";
            // 
            // btnInstallAddon
            // 
            this.btnInstallAddon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInstallAddon.Location = new System.Drawing.Point(16, 85);
            this.btnInstallAddon.Name = "btnInstallAddon";
            this.btnInstallAddon.Size = new System.Drawing.Size(198, 39);
            this.btnInstallAddon.TabIndex = 1;
            this.btnInstallAddon.Text = "Install";
            this.btnInstallAddon.UseVisualStyleBackColor = true;
            this.btnInstallAddon.Click += new System.EventHandler(this.btnInstallAddon_Click);
            // 
            // cbLibraryAddons
            // 
            this.cbLibraryAddons.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLibraryAddons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLibraryAddons.FormattingEnabled = true;
            this.cbLibraryAddons.IntegralHeight = false;
            this.cbLibraryAddons.ItemHeight = 34;
            this.cbLibraryAddons.Location = new System.Drawing.Point(16, 29);
            this.cbLibraryAddons.MaxDropDownItems = 15;
            this.cbLibraryAddons.Name = "cbLibraryAddons";
            this.cbLibraryAddons.Size = new System.Drawing.Size(600, 40);
            this.cbLibraryAddons.TabIndex = 0;
            this.cbLibraryAddons.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbLibraryAddons_DrawItem);
            // 
            // lblAction
            // 
            this.lblAction.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAction.Location = new System.Drawing.Point(12, 360);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(367, 19);
            this.lblAction.TabIndex = 2;
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 390);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.grbAddonLibrary);
            this.Controls.Add(this.grbInstalledAddons);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanilla WoW Toppings - An AddOn Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.grbInstalledAddons.ResumeLayout(false);
            this.grbAddonLibrary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPreferences;
        private System.Windows.Forms.ToolStripMenuItem miLaunchWow;
        private System.Windows.Forms.ToolStripMenuItem miPerformBackup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ComboBox cbInstalledAddons;
        private System.Windows.Forms.GroupBox grbInstalledAddons;
        private System.Windows.Forms.Button btnUninstallAddon;
        private System.Windows.Forms.GroupBox grbAddonLibrary;
        private System.Windows.Forms.Button btnInstallAddon;
        private System.Windows.Forms.ComboBox cbLibraryAddons;
        private System.Windows.Forms.ToolStripMenuItem directoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpenGameDirectory;
        private System.Windows.Forms.ToolStripMenuItem miOpenAddonLibraryDirectory;
        private System.Windows.Forms.ToolStripMenuItem miOpenBackupDirectory;
        private System.Windows.Forms.ToolStripMenuItem miRestoreBackup;
        private System.Windows.Forms.Label lblAction;
    }
}

