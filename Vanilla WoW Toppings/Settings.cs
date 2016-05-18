using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Vanilla_WoW_Toppings
{
    abstract class Settings
    {
        // Application constants.
        public static readonly string StartupPath = Application.StartupPath;
        public const string ApplicationTitle = "Vanilla WoW Toppings";
        public const string ApplicationFilename = ApplicationTitle + ".exe";

        // WoW and addon file/directory settings.
        public const string WowFilename = "WoW.exe";
        public const string SettingsFilename = "Settings.txt";
        public const string WowAddonDirectoryPath = "Interface/AddOns";
        public const string AddonFileExtension = ".toc";
        public const string AddonsExcludedThatStartsWith = "Blizzard_";

        // Addon combobox item colors.
        public static readonly Color NormalAddonItemColor = Color.Black;
        public static readonly Color SelectedAddonItemColor =
            Color.FromArgb(25, 130, 25);
        // Addon combobox item offset.
        public const int AddonItemNotesOffsetX = 12;
        public const int AddonItemNotesOffsetY = 16;

        // Directory path variables.
        public static string WowGameDirectoryPath = string.Empty;
        public static string AddonLibraryDirectoryPath = string.Empty;
        public static string BackupDirectoryPath = string.Empty;

        // Realmlists
        public static List<string> Realmlists = new List<string>();
        public static string CurrentRealmlist = string.Empty;

        public static void SaveSettings()
        {
            // Set the filepath of the settings file.
            var settingsFilepath = Path.Combine(
                StartupPath,
                SettingsFilename);

            try
            {
                // Write the settings to the settings file.
                using (var writer = new StreamWriter(settingsFilepath))
                {
                    var filetext = new StringBuilder();
                    
                    // Append the WoW game directory path.
                    filetext.Append(
                        "WowDirectory=" + WowGameDirectoryPath);

                    // Append the addon library directory path.
                    filetext.Append(
                        "\r\nAddonLibraryDirectory=" + AddonLibraryDirectoryPath);

                    // Append the backup directory path.
                    filetext.Append(
                        "\r\nBackupDirectory=" + BackupDirectoryPath);

                    // Append the realmlists.
                    filetext.Append("\r\nRealmlists=");
                    for (var i = 0; i < Realmlists.Count; i++)
                    {
                        filetext.Append(Realmlists[i]);
                        if (i < Realmlists.Count - 1)
                        {
                            filetext.Append(";");
                        }
                    }
                    filetext.Append(
                        "\r\nCurrentRealmlist=" + CurrentRealmlist);


                    // Write to the file then close it.
                    writer.Write(filetext.ToString());
                    writer.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(
                    "An error occured when saving the "+
                        "application settings.\r\n\r\n" +
                        "Error message:\r\n" + exception.Message,
                    ApplicationTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void LoadSettings()
        {
            // Set the filepath of the settings file.
            var settingsFilepath = Path.Combine(
                StartupPath,
                SettingsFilename);

            if (File.Exists(settingsFilepath))
            {
                try
                {
                    using (var reader = new StreamReader(settingsFilepath))
                    {
                        var splitChar = '=';

                        // Load the WoW game directory path.
                        WowGameDirectoryPath = reader.ReadLine().
                            Split(splitChar)[1];

                        // Load the addon library directory path.
                        AddonLibraryDirectoryPath = reader.ReadLine().
                            Split(splitChar)[1];

                        // Load the backup directory path.
                        BackupDirectoryPath = reader.ReadLine().
                            Split(splitChar)[1];

                        // Load realmlists.
                        var realmlists = reader.ReadLine().
                            Split(splitChar)[1].Split(';');
                        for (var i = 0; i < realmlists.Length; i++)
                        {
                            Realmlists.Add(realmlists[i]);
                        }
                        CurrentRealmlist = reader.ReadLine().
                            Split(splitChar)[1];

                        reader.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        "An error occured when loading the " +
                            "application settings.\r\n\r\n" +
                            "Error message:\r\n" + exception.Message,
                        ApplicationTitle,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}