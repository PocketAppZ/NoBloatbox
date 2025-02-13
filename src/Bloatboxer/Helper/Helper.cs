using Bloatboxer;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Helper
{
    public static class Utils
    {
        // Check if the plugin environment is ready
        public static bool IsPluginEnvironmentReady()
        {
            return Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins"));
        }

        // Get the desktop wallpaper path
        public static string GetDesktopWallpaper()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop"))
                {
                    if (key != null)
                    {
                        object wallpaperPath = key.GetValue("Wallpaper");
                        if (wallpaperPath != null)
                        {
                            return wallpaperPath.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return string.Empty;
        }

        // Check for app updates
        public static bool CheckForAppUpdates()
        {
            if (!IsInternetAvailable())
            {
                MessageBox.Show("No internet connection. Update check failed.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                string versionInfoUrl = "https://raw.githubusercontent.com/builtbybel/Bloatboxer/main/src/Bloatboxer/Properties/AssemblyInfo.cs";
                string assemblyInfo = new WebClient().DownloadString(versionInfoUrl);

                string latestVersion = assemblyInfo
                    .Split('\n')
                    .FirstOrDefault(line => line.Contains("[assembly: AssemblyFileVersion"))?
                    .Split('"')[1]; // Extract version string

                if (latestVersion == Program.GetAppVersion())
                {
                    MessageBox.Show("No new updates available.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    string downloadUrl = "https://github.com/builtbybel/Bloatboxer/releases";

                    if (MessageBox.Show($"App version {latestVersion} is available.\nOpen the download page?",
                                        "App Update Available",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Process.Start(downloadUrl);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to check for updates. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Check Internet connectivity
        private static bool IsInternetAvailable()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}