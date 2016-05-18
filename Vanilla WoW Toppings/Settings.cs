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
        public const string GameDataAddonPath = "Interface/AddOns";
        public const string AddonFileExtension = ".toc";
        public const string ExcludeAddonsThatBeginWith = "Blizzard_";
        public const string RealmlistFilename = "realmlist.wtf";

        // Addon combobox item colors.
        public static readonly Color DefaultAddonItemColor = Color.Black;
        public static readonly Color SelectedAddonItemColor =
            Color.FromArgb(25, 130, 25);
        // Addon combobox item offset.
        public const int AddonItemNotesOffsetX = 12;
        public const int AddonItemNotesOffsetY = 16;

        // Directory path variables.
        public static string GameDataPath = string.Empty;
        public static string AddonLibraryPath = string.Empty;
        public static string BackupStoragePath = string.Empty;

        public static int MaxStoredBackups = 5;

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
                        "GAME-DATA=" + GameDataPath);

                    // Append the addon library directory path.
                    filetext.Append(
                        "\r\nADDON-LIBRARY=" + AddonLibraryPath);

                    // Append the backup directory path.
                    filetext.Append(
                        "\r\nBACKUP-STORAGE=" + BackupStoragePath);

                    // Append the max number of backups to store.
                    filetext.Append(
                        "\r\nMAX-STORED-BACKUPS=" + MaxStoredBackups);

                    // Append the realmlists.
                    filetext.Append("\r\nREALMLISTS=");
                    for (var i = 0; i < Realmlists.Count; i++)
                    {
                        filetext.Append(Realmlists[i]);
                        if (i < Realmlists.Count - 1)
                        {
                            filetext.Append(";");
                        }
                    }
                    filetext.Append(
                        "\r\nCURRENT-REALMLIST=" + CurrentRealmlist);


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
                        GameDataPath = reader.ReadLine().
                            Split(splitChar)[1];

                        // Load the addon library directory path.
                        AddonLibraryPath = reader.ReadLine().
                            Split(splitChar)[1];

                        // Load the backup directory path.
                        BackupStoragePath = reader.ReadLine().
                            Split(splitChar)[1];

                        // Load max stored backups.
                        MaxStoredBackups = Convert.ToInt32(reader.ReadLine().
                            Split(splitChar)[1]);

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