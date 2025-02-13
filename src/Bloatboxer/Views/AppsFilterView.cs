using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bloatboxer.AppsView;

namespace Bloatboxer
{
    public partial class AppsFilterView : UserControl
    {
        private NavigationManager navigationManager;

        private List<AppInfo> appxPackages = new List<AppInfo>();

        public AppsFilterView(NavigationManager navigationManager)
        {
            InitializeComponent();
            this.navigationManager = navigationManager;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var searchPatterns = textFilter.Text
                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .Where(p => !string.IsNullOrWhiteSpace(p))
                .ToList();

            if (searchPatterns.Count == 0)
            {
                MessageBox.Show("Please enter one or more app names.", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateStatusLabel("No search pattern entered.");
                return;
            }

            UpdateStatusLabel("Searching for matching apps...");

            LoadAppxPackages().ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    Invoke(new Action(() => UpdateStatusLabel("Error loading app packages.")));
                    return;
                }

                var matchedApps = appxPackages.Where(app =>
                    searchPatterns.Any(pattern => WildcardMatch(app.Name, pattern))).ToList();

                Invoke(new Action(() =>
                {
                    DisplayApps(matchedApps);

                    if (matchedApps.Count > 0)
                    {
                        UpdateStatusLabel($"{matchedApps.Count} apps matched your search.");
                    }
                    else
                    {
                        UpdateStatusLabel("No matching apps found.");
                    }
                }));
            });
        }

        private bool WildcardMatch(string input, string pattern)
        {
            // Allowing wildcards 
            string regexPattern = ".*" + System.Text.RegularExpressions.Regex.Escape(pattern).Replace("\\*", ".*") + ".*";
            return System.Text.RegularExpressions.Regex.IsMatch(input, regexPattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

        private void DisplayApps(List<AppInfo> apps)
        {
            checkedListBoxApps.Items.Clear();
            foreach (var app in apps)
            {
                checkedListBoxApps.Items.Add(app, false);
            }
        }

        private void UpdateStatusLabel(string message)
        {
            statusLabel.Text = message;
            statusLabel.Refresh();
        }

        private async Task LoadAppxPackages()
        {
            appxPackages.Clear();
            UpdateStatusLabel("Loading app packages...");

            var processStartInfo = new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = "Get-AppxPackage | Select-Object -Property Name | Format-Table -HideTableHeaders",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new Process { StartInfo = processStartInfo })
            {
                process.Start();

                string output;
                while ((output = await process.StandardOutput.ReadLineAsync()) != null)
                {
                    var parts = output.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 1)
                    {
                        appxPackages.Add(new AppInfo { Name = parts[0] });
                    }
                }

                await process.WaitForExitAsync();
            }
            UpdateStatusLabel($"Loaded {appxPackages.Count} app packages.");
        }

        private async Task RemoveApp(AppInfo app)
        {
            try
            {
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = $"Get-AppxPackage -Name {app.Name} | Remove-AppxPackage",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();
                    await process.StandardOutput.ReadToEndAsync();
                    string errorOutput = await process.StandardError.ReadToEndAsync();

                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        MessageBox.Show($"Error removing '{app.Name}': {errorOutput}", "Removal Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateStatusLabel($"Error removing '{app.Name}'.");
                    }

                    await process.WaitForExitAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            // Check if any apps are selected for removal
            if (checkedListBoxApps.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one app to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            UpdateStatusLabel("Removing selected apps...");

            // Get the list of selected apps
            List<AppInfo> selectedApps = checkedListBoxApps.CheckedItems.Cast<AppInfo>().ToList();

            foreach (var app in selectedApps)
            {
                // Remove the app and handle errors if any
                await RemoveApp(app);
                UpdateStatusLabel($"Removed {app.Name} successfully.");

                // Remove the app from the local list to keep the UI consistent
                appxPackages.Remove(app);
            }

            UpdateStatusLabel("All selected apps removed successfully.");

            // Reload and filter the remaining apps based on user input
            var searchPatterns = textFilter.Text
                .Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .Where(p => !string.IsNullOrWhiteSpace(p))
                .ToList();

            // Filter the remaining apps using wildcard matching
            var remainingApps = appxPackages.Where(app =>
                searchPatterns.Any(pattern => WildcardMatch(app.Name, pattern))).ToList();

            // Update the UI with the filtered app list
            DisplayApps(remainingApps);
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (navigationManager.CanGoBack())
            {
                navigationManager.GoBack();
            }
        }

        private void linkSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool shouldCheck = checkedListBoxApps.CheckedItems.Count < checkedListBoxApps.Items.Count;

            // Toggle all items
            for (int i = 0; i < checkedListBoxApps.Items.Count; i++)
            {
                checkedListBoxApps.SetItemChecked(i, shouldCheck);
            }

            // Update button text for clarity
            linkSelect.Text = shouldCheck ? "Unselect All" : "Select All";
        }
    }
}