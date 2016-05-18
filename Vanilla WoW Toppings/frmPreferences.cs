using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vanilla_WoW_Toppings
{
    public partial class frmPreferences : Form
    {
        #region Properties
        public string InstalledWowDirectory
        {
            get { return txtGameDataPath.Text.Trim(); }
        }
        public string AddonLibraryDirectory
        {
            get { return txtAddonLibraryPath.Text.Trim(); }
        }
        public string BackupDirectory
        {
            get { return txtBackupStoragePath.Text.Trim(); }
        }
        public int MaxStoredBackups
        {
            get { return (int)numMaxStoredBackups.Value; }
        }
        public List<string> Realmlists
        {
            get { return realmlists; }
        }
        public string CurrentRealmlist
        {
            get
            {
                return cbRealmlists.Text.Trim().Length > 0 ?
                    cbRealmlists.Text.Trim() :
                    Settings.CurrentRealmlist;
            }
        }
        #endregion

        #region Members
        List<string> realmlists;
        #endregion

        public frmPreferences()
        {
            InitializeComponent();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            btnOK.DialogResult = DialogResult.OK;

            txtGameDataPath.Text = Settings.GameDataPath;
            txtAddonLibraryPath.Text = Settings.AddonLibraryPath;
            txtBackupStoragePath.Text = Settings.BackupStoragePath;
            numMaxStoredBackups.Value = Settings.MaxStoredBackups;

            realmlists = new List<string>();
            for (var i = 0; i < Settings.Realmlists.Count; i++)
            {
                realmlists.Add(Settings.Realmlists[i]);
                cbRealmlists.Items.Add(Settings.Realmlists[i]);
            }

            cbRealmlists.Text = Settings.CurrentRealmlist;
        }

        private void btnBrowseWowFolder_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();

            folderBrowser.Description = "Select the WoW client directory.";
            folderBrowser.SelectedPath = txtGameDataPath.Text;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtGameDataPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnBrowseAddonsFolder_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();

            folderBrowser.Description = "Select your AddOn library directory.";
            folderBrowser.SelectedPath = txtAddonLibraryPath.Text;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtAddonLibraryPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnBrowseBackupFolder_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();

            folderBrowser.Description = "Select the directory to store backups in.";
            folderBrowser.SelectedPath = txtBackupStoragePath.Text;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtBackupStoragePath.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnAddRealm_Click(object sender, EventArgs e)
        {
            if (cbRealmlists.Text.Length > 0 &&
                !realmlists.Contains(cbRealmlists.Text))
            {
                realmlists.Add(cbRealmlists.Text);
                cbRealmlists.Items.Add(cbRealmlists.Text);
            }
        }

        private void btnRemoveRealm_Click(object sender, EventArgs e)
        {
            if (cbRealmlists.Items.Count > 0 && cbRealmlists.SelectedIndex >= 0)
            {
                try
                {
                    realmlists.RemoveAt(cbRealmlists.SelectedIndex);
                    cbRealmlists.Items.RemoveAt(cbRealmlists.SelectedIndex);
                }
                catch { }
                cbRealmlists.Text = string.Empty;
            }
        }
    }
}