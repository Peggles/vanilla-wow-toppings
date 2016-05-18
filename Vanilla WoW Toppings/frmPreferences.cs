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
            get { return txtWowFolder.Text.Trim(); }
        }
        public string AddonLibraryDirectory
        {
            get { return txtAddonsFolder.Text.Trim(); }
        }
        public string BackupDirectory
        {
            get { return txtBackupFolder.Text.Trim(); }
        }
        public List<string> Realmlists
        {
            get { return realmlists; }
        }
        public string CurrentRealmlist
        {
            get { return cbRealmlists.Text.Trim(); }
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

            txtWowFolder.Text = Settings.WowGameDirectoryPath;
            txtAddonsFolder.Text = Settings.AddonLibraryDirectoryPath;
            txtBackupFolder.Text = Settings.BackupDirectoryPath;

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

            folderBrowser.Description = "Choose your installed WoW game directory.";
            folderBrowser.SelectedPath = txtWowFolder.Text;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtWowFolder.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnBrowseAddonsFolder_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();

            folderBrowser.Description = "Choose your AddOn library directory.";
            folderBrowser.SelectedPath = txtAddonsFolder.Text;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtAddonsFolder.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnBrowseBackupFolder_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();

            folderBrowser.Description = "Choose a backup directory.";
            folderBrowser.SelectedPath = txtBackupFolder.Text;

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtBackupFolder.Text = folderBrowser.SelectedPath;
            }
        }

        private void btnAddRealm_Click(object sender, EventArgs e)
        {
            if (cbRealmlists.Text.Length > 0 && !realmlists.Contains(cbRealmlists.Text))
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