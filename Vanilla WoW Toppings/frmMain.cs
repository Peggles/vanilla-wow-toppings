using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanilla_WoW_Toppings
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        void InitializeApplication()
        {
            UpdateControlAvailability();
            LoadInstalledAddons();
            LoadAddonLibrary();
        }

        void LoadAddons(ComboBox comboBox, string groupBoxText,
            string addonCollectionDirectoryPath)
        {
            // Clear the addons in the combobox.
            comboBox.Items.Clear();

            // Get the addon directory info from the directory path.
            var addonCollectionDirectory = new DirectoryInfo(
                addonCollectionDirectoryPath);

            if (addonCollectionDirectory.Exists)
            {
                try
                {
                    // Add all the appropriate addons to the combobox.
                    foreach (var addon in addonCollectionDirectory.
                        GetDirectories())
                    {
                        // Add only addons that do not begin with
                        // the specified set of characters.
                        if (!addon.Name.StartsWith(
                            Settings.ExcludeAddonsThatBeginWith))
                        {
                            comboBox.Items.Add(addon.Name);
                        }
                    }
                }
                catch (DirectoryNotFoundException exception)
                {
                    MessageBox.Show(
                        "An error occurred when loading the AddOns.\r\n\r\n" +
                            "Error message:\r\n" + exception.Message,
                        Settings.ApplicationTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            // Set the groupbox text to the number of addons in the combobox.
            comboBox.Parent.Text = groupBoxText + " (" +
                comboBox.Items.Count + ")";
        }

        void LoadInstalledAddons()
        {
            // Set the directory path for the installed addons.
            var installedAddonsDirectoryPath = Path.Combine(
                Settings.GameDataPath,
                Settings.GameDataAddonPath);

            // Add all the installed addons to the combobox.
            LoadAddons(
                cbInstalledAddons,
                "Installed AddOns",
                installedAddonsDirectoryPath);
        }

        void LoadAddonLibrary()
        {
            // Set the directory path for the addon library.
            var addonLibraryDirectoryPath =
                Settings.AddonLibraryPath;

            // Add all the addons in the addon library to the combobox.
            LoadAddons(
                cbLibraryAddons,
                "AddOn Library",
                addonLibraryDirectoryPath);
        }

        void UpdateControlAvailability()
        {
            // Set the availability of the WoW game data directory.
            var isGameDataDirectoryExisting = Directory.Exists(
                Settings.GameDataPath);
            miOpenGameDirectory.Enabled = isGameDataDirectoryExisting;
            miLaunchWow.Enabled = isGameDataDirectoryExisting;

            // Set the availability of the addon library directory.
            var isAddonLibraryDirectoryExisting = Directory.Exists(
                Settings.AddonLibraryPath);
            miOpenAddonLibraryDirectory.Enabled = isAddonLibraryDirectoryExisting;

            // Set the availability of the backup directory.
            var isBackupStorageDirectoryExisting = Directory.Exists(
                Settings.BackupStoragePath);
            miPerformBackup.Enabled = isBackupStorageDirectoryExisting;
            miRestoreBackup.Enabled = isBackupStorageDirectoryExisting;
            miOpenBackupDirectory.Enabled = isBackupStorageDirectoryExisting;

            // Set the availability of the installed addons.
            grbInstalledAddons.Enabled = isGameDataDirectoryExisting;

            // Set the availability of the addon library.
            grbAddonLibrary.Enabled = isAddonLibraryDirectoryExisting;
        }

        string GetAddonNotes(string addonName, string addonDirectoryPath)
        {
            // Get the addon notes file.
            var addonNotesFile = new FileInfo(addonDirectoryPath);

            if (addonNotesFile.Exists)
            {
                try
                {
                    using (var reader = new StreamReader(
                        addonNotesFile.FullName))
                    {
                        while (!reader.EndOfStream)
                        {
                            // If the line starts with "## Notes:" we have a match.
                            string readLine = reader.ReadLine();
                            if (readLine.StartsWith("## Notes:"))
                            {
                                // Get the addon notes from the line that was read.
                                var addonNotesText = readLine;

                                // Remove the prefix/title from the notes.
                                addonNotesText = addonNotesText.Replace(
                                    "## Notes:",
                                    string.Empty).Trim();

                                return addonNotesText;
                            }
                        }
                        reader.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        "Unable to load the AddOns.\r\n\r\n" +
                            "Error message:\r\n" + exception.Message,
                        Settings.ApplicationTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            return string.Empty;
        }

        async void PerformAddonsAndSettingsBackup()
        {
            // Check if the backup directory exists.
            var isBackupDirectoryAvailable =
                Directory.Exists(Settings.BackupStoragePath);

            if (isBackupDirectoryAvailable)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        // Get the current date and time
                        // and remove special characters.
                        var currentDate = DateTime.Now.Date.ToShortDateString();
                        currentDate = currentDate.Replace("-", string.Empty);
                        var currentTime = DateTime.Now.ToLongTimeString();
                        currentTime = currentTime.Replace(":", string.Empty);

                        // Set the backup directory name.
                        var backupDirectoryName = currentDate + "_" + currentTime;

                        // Set the WoW installed addons directory.
                        var wowInstalledAddonsDirectory = new DirectoryInfo(
                            Path.Combine(
                                Settings.GameDataPath,
                                Settings.GameDataAddonPath));

                        // Set the WoW WTF (settings) directory.
                        var wowWtfDirectory = new DirectoryInfo(Path.Combine(
                            Settings.GameDataPath,
                            "WTF"));

                        // Set the new backup directory.
                        var newBackupDirectory = new DirectoryInfo(Path.Combine(
                            Settings.BackupStoragePath,
                            backupDirectoryName));

                        // Create the backup directory.
                        newBackupDirectory.Create();

                        // Set the new addons directory.
                        var newAddonDirectory = new DirectoryInfo(Path.Combine(
                            newBackupDirectory.FullName,
                            "AddOns"));

                        // Create the addons directory.
                        newAddonDirectory.Create();

                        // Set the new WTF directory.
                        DirectoryInfo newWtfDir = new DirectoryInfo(Path.Combine(
                            newBackupDirectory.FullName,
                            "WTF"));

                        // Create the WTF directory.
                        newWtfDir.Create();

                        // Copy files from the original WoW directory
                        // to the new backup directory.
                        CopyFiles(
                            wowInstalledAddonsDirectory.FullName,
                            newAddonDirectory.FullName);
                        CopyFiles(
                            wowWtfDirectory.FullName,
                            newWtfDir.FullName);

                        // Display a "success" message.
                        MessageBox.Show(
                            "The AddOns and settings backup was successful.",
                            Settings.ApplicationTitle,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        "The backup was unsuccessful. Please try again.\r\n\r\n" +
                            "Error message:\r\n" + exception.Message,
                        Settings.ApplicationTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        void CopyFiles(string sourceDirectoryPath, string targetDirectoryPath)
        {
            // Set source and target directories.
            var sourceDirectory = new DirectoryInfo(sourceDirectoryPath);
            var targetDirectory = new DirectoryInfo(targetDirectoryPath);

            // Create the target directory if it doesn't exist.
            if (!targetDirectory.Exists)
            {
                targetDirectory.Create();
            }

            // Copy all files from the source directory to the target directory.
            foreach (var sourceFile in sourceDirectory.GetFiles())
            {
                // Set the target filepath.
                var targetFilepath = Path.Combine(
                    targetDirectory.FullName,
                    sourceFile.Name);

                // Copy (and overwrite if needed) the source file to the
                // target directory.
                sourceFile.CopyTo(targetFilepath, true);
            }

            // Do a recursive loopthrough of the sub directories.
            foreach (var subDirectory in sourceDirectory.GetDirectories())
            {
                CopyFiles(subDirectory.FullName, Path.Combine(
                    targetDirectory.FullName,
                    subDirectory.Name));
            }
        }

        void OpenDirectory(string directoryPath)
        {
            // Set the directory.
            var directory = new DirectoryInfo(directoryPath);

            if (directory.Exists)
            {
                // Open the directory.
                try
                {
                    Process.Start(directoryPath);
                }
                catch (DirectoryNotFoundException exception)
                {
                    MessageBox.Show(
                        "Unable to open the selected directory." +
                            "Check your settings.\r\n\r\n" +
                            "Error message:\r\n" + exception.Message,
                        Settings.ApplicationTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Unable to find the selected directory.\r\n" +
                        "Check your settings in Settings -> Preferences.",
                    Settings.ApplicationTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        void DrawAddonItem(ComboBox comboBox, DrawItemEventArgs e)
        {
            // Redraw the item background.
            e.DrawBackground();

            if (e.Index >= 0)
            {
                // Get the graphics object from the event.
                var graphics = e.Graphics;

                // Set the font of the addon title.
                var font = new Font(
                    new FontFamily("Segoe UI"),
                    10,
                    FontStyle.Bold);

                // Check if this combobox is "cbLibraryAddons"
                // and the addon is already installed.
                bool isInstalled = cbInstalledAddons.Items.Contains(
                        comboBox.Items[e.Index]);

                // Get the addon name.
                var addonName = comboBox.Items[e.Index].ToString();

                // Set the item text.
                var itemText = addonName;

                // Set the brush (text color).
                var brush = new SolidBrush(Settings.DefaultAddonItemColor);

                if (comboBox == cbLibraryAddons && isInstalled)
                {
                    itemText = addonName + " [Installed]";
                    brush.Color = Settings.SelectedAddonItemColor;
                }

                // Draw the addon title.
                graphics.DrawString(
                    itemText,
                    font,
                    brush,
                    e.Bounds.X,
                    e.Bounds.Y);

                // Get the addon filepath depending on which combobox this is.
                var addonFilepath = string.Empty;
                if (comboBox == cbInstalledAddons)
                {
                    // Get the filepath of the selected addon.
                    addonFilepath = Path.Combine(
                        Settings.GameDataPath,
                        Path.Combine(
                            Settings.GameDataAddonPath,
                            Path.Combine(
                                addonName,
                                addonName + Settings.AddonFileExtension)));
                }
                else
                {
                    // Set the addon library filepath.
                    addonFilepath = Path.Combine(
                        Settings.AddonLibraryPath,
                        Path.Combine(
                            addonName,
                            addonName + Settings.AddonFileExtension));
                }

                // Set the font of the addon notes.
                font = new Font(
                    new FontFamily("Segoe UI"),
                    9);

                // Draw the addon notes.
                graphics.DrawString(
                    GetAddonNotes(addonName, addonFilepath),
                    font,
                    brush,
                    e.Bounds.X + Settings.AddonItemNotesOffsetX,
                    e.Bounds.Y + Settings.AddonItemNotesOffsetY);
            }
        }

        void UpdateRealmlist(string realm)
        {
            try
            {
                var realmlistFilePath = Path.Combine(
                    Settings.GameDataPath,
                    Settings.RealmlistFilename);
                using (var writer = new StreamWriter(realmlistFilePath))
                {
                    writer.Write("set realmlist " + realm);
                    writer.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "An error occured when updating the" +
                        "realmlist.\r\n\r\n" +
                        "Error message:\r\n" + exception.Message,
                    Settings.ApplicationTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Settings.LoadSettings();
            InitializeApplication();

            miRestoreBackup.Visible = false;
        }

        private void cbInstalledAddons_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawAddonItem(cbInstalledAddons, e);
        }

        private void cbLibraryAddons_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawAddonItem(cbLibraryAddons, e);
        }

        private void btnUninstallAddon_Click(object sender, EventArgs e)
        {
            if (cbInstalledAddons.Items.Count > 0 &&
                cbInstalledAddons.SelectedIndex >= 0)
            {
                try
                {
                    // Set the directory path of the selected addon.
                    var selectedAddonDirectoryPath = new DirectoryInfo(
                        Path.Combine(
                            Settings.GameDataPath,
                            Path.Combine(
                                Settings.GameDataAddonPath,
                                cbInstalledAddons.SelectedItem.ToString())));

                    // Delete the addon directory.
                    selectedAddonDirectoryPath.Delete(true);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        "Unable to uninstall the selected AddOn. " +
                            "Please try again.\r\n\r\n" +
                            "Error message:\r\n" + exception.Message,
                        Settings.ApplicationTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Reload the installed addons
                // and refresh the installed addons combobox.
                LoadInstalledAddons();
                cbInstalledAddons.Invalidate();
                cbLibraryAddons.Invalidate();
            }
        }

        private void btnInstallAddon_Click(object sender, EventArgs e)
        {
            if (cbLibraryAddons.Items.Count > 0 &&
                cbLibraryAddons.SelectedIndex >= 0)
            {
                // Set the WoW game directory.
                var wowGameDirectory = new DirectoryInfo(
                    Settings.GameDataPath);

                if (wowGameDirectory.Exists)
                {
                    // Set the selected addon's target path.
                    var selectedAddonTargetDirectoryPath = new DirectoryInfo(
                        Path.Combine(
                            Settings.GameDataPath,
                            Path.Combine(
                                Settings.GameDataAddonPath,
                                cbLibraryAddons.SelectedItem.ToString())));

                    if (selectedAddonTargetDirectoryPath.Exists)
                    {
                        // Delete the target addon if it's already installed
                        // (so we can install a fresh copy).
                        try
                        {
                            selectedAddonTargetDirectoryPath.Delete(true);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(
                                "Unable to remove the old copy of this AddOn. " +
                                    "The application will continue to install the AddOn," +
                                    "but errors might occurr.\r\nIf that's the case," +
                                    "just re-install the AddOn.\r\n\r\n" +
                                    "Error message:\r\n" + exception.Message,
                                Settings.ApplicationTitle,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }

                    // Set the selected addon's source path.
                    var selectedAddonSourceDirectoryPath = Path.Combine(
                        Settings.AddonLibraryPath,
                        cbLibraryAddons.SelectedItem.ToString());

                    // Copy the source files and directories to
                    // the target directory.
                    CopyFiles(
                        selectedAddonSourceDirectoryPath,
                        selectedAddonTargetDirectoryPath.FullName);

                    // Reload the installed addons
                    // and refresh the addon library combobox.
                    LoadInstalledAddons();
                    cbInstalledAddons.Invalidate();
                    cbLibraryAddons.Invalidate();

                    // Select the newly installed addon.
                    try
                    {
                        cbInstalledAddons.SelectedItem =
                            cbLibraryAddons.SelectedItem;
                    }
                    catch
                    {
                        // No catch.
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No WoW game directory was found.\r\n" +
                            "Set the game directory under Preferences -> Settings.",
                        Settings.ApplicationTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        #region Menu
        private void miPerformBackup_Click(object sender, EventArgs e)
        {
            PerformAddonsAndSettingsBackup();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miPreferences_Click(object sender, EventArgs e)
        {
            var preferenceForm = new frmPreferences();

            if (preferenceForm.ShowDialog(this) == DialogResult.OK)
            {
                // Set the WoW game directory path.
                Settings.GameDataPath =
                    preferenceForm.InstalledWowDirectory;
                // Set the addon library directory path.
                Settings.AddonLibraryPath =
                    preferenceForm.AddonLibraryDirectory;
                // Set the backup directory path.
                Settings.BackupStoragePath =
                    preferenceForm.BackupDirectory;
                Settings.MaxStoredBackups = preferenceForm.MaxStoredBackups;
                // Set the realmlists.
                Settings.Realmlists = preferenceForm.Realmlists;
                Settings.CurrentRealmlist = preferenceForm.CurrentRealmlist;

                UpdateRealmlist(Settings.CurrentRealmlist);

                // Save the settings.
                Settings.SaveSettings();

                // Reload all settings.
                InitializeApplication();
            }
        }

        private void miLaunchWow_Click(object sender, EventArgs e)
        {
            // Launch WoW.exe then close this application.
            try
            {
                Process.Start(Path.Combine(
                    Settings.GameDataPath,
                    Settings.WowFilename));

                Application.Exit();
            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(
                    "Unable to launch '" + Settings.WowFilename + "'. Check " +
                        "your game folder in Settings -> Preferences.\r\n\r\n" +
                        "Error message:\r\n" + exception.Message,
                    Settings.ApplicationTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        #endregion

        private void miOpenGameDirectory_Click(object sender, EventArgs e)
        {
            OpenDirectory(Settings.GameDataPath);
        }

        private void miOpenAddonLibraryDirectory_Click(object sender, EventArgs e)
        {
            OpenDirectory(Settings.AddonLibraryPath);
        }

        private void miOpenBackupDirectory_Click(object sender, EventArgs e)
        {
            OpenDirectory(Settings.BackupStoragePath);
        }
    }
}