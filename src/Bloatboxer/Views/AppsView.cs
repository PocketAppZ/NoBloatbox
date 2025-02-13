using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloatboxer
{
    public partial class AppsView : UserControl
    {
        private NavigationManager navigationManager;

        private List<FilterDefinition> filters = new List<FilterDefinition>();
        private List<AppInfo> appxPackages = new List<AppInfo>();
        private List<AppInfo> displayedApps = new List<AppInfo>();

        private string jsonFileName;
        private string jsonDescription;
        private string jsonSource;
        private bool excludeAllAppsView = false;

        public class FilterDefinition
        {
            public string Name { get; set; }
            public List<string> Criteria { get; set; }
        }

        public class FiltersContainer
        {
            public List<FilterDefinition> Filters { get; set; }
            public string Description { get; set; }
            public string Source { get; set; }
            public bool excludeAllAppsView { get; set; }
        }

        public class AppInfo
        {
            public string PackageFullName { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return Name ?? PackageFullName;
            }
        }

        public AppsView(NavigationManager navigationManager)
        {
            InitializeComponent();
            this.navigationManager = navigationManager;
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Set the Segoe MDL2 Assets font for the icons
            btnBack.Text = "\uE72B";                // Back icon
            btnRefresh.Text = "\ue72c";             // Refresh icon
            btnCheckList.Text = "\uE9D5";           // Select icon
            btnShare.Text = "\uE72D";                // Share icon
        }

        private void filterDropdown_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            int padding = 30;

            // Draw the item text
            string text = filterDropdown.Items[e.Index].ToString();
            e.Graphics.DrawString(text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + padding, e.Bounds.Y);

            e.DrawFocusRectangle();
        }

        public async Task LoadFilters(string filePath)
        {
            try
            {
                // Read the JSON content from the file
                string jsonContent = File.ReadAllText(filePath);

                // Deserialize the JSON into the FiltersContainer object
                var filtersContainer = JsonConvert.DeserializeObject<FiltersContainer>(jsonContent);

                if (filtersContainer != null)
                {
                    filters = filtersContainer.Filters;             // Store filters from the file
                    jsonDescription = filtersContainer.Description; // Set the description
                    jsonSource = filtersContainer.Source;           // Set the source/author
                    excludeAllAppsView = filtersContainer.excludeAllAppsView;

                    jsonFileName = Path.GetFileNameWithoutExtension(filePath);

                    InitializeFilterOptions(filePath);             // Initialize filter options
                    UpdateStatusLabel("Filters loaded successfully");
                    LoadAppxPackages();                            // Load installed apps
                    UpdateJsonInfoDisplay();                       // Update UI with JSON info
                }
                else
                {
                    MessageBox.Show("No filters found in the file.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading filters: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update the description and author labels with the JSON file info
        private void UpdateJsonInfoDisplay()
        {
            lblDescription.Text = jsonDescription;
            lblSource.Text = jsonSource;
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            // Get the selected filter name from the ComboBox
            string selectedFilter = filterDropdown.SelectedItem.ToString();

            // Apply the selected filter
            ApplyFilter(selectedFilter);
        }

        private void ApplyFilter(string filterName)
        {
            // Check if the selected filter is the "All apps" = JSON file name equivalent
            if (filterName.Equals(jsonFileName, StringComparison.OrdinalIgnoreCase) && !excludeAllAppsView)
            {
                // Show all apps if "All apps" is selected and it's not disabled
                displayedApps = new List<AppInfo>(appxPackages);
            }
            else

            {
                // Apply the selected filter logic
                var selectedFilter = filters.FirstOrDefault(f => f.Name == filterName);
                if (selectedFilter != null)
                {
                    displayedApps = appxPackages.Where(app =>
                        selectedFilter.Criteria.Any(criteria =>
                            app.Name.IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
                }
            }

            DisplayApps(displayedApps);
        }

        private void InitializeFilterOptions(string jsonFilePath)
        {
            // Get the name of the JSON file without the extension
            string jsonFileName = Path.GetFileNameWithoutExtension(jsonFilePath);

            filterDropdown.Items.Clear();
            //comboBoxFilters.Items.Add("All apps");

            // Add the JSON file name as the first option
            if (!excludeAllAppsView) // Only add the "All apps" category if the property is false
            {
                filterDropdown.Items.Add(jsonFileName);
            }

            foreach (var filter in filters)
            {
                filterDropdown.Items.Add(filter.Name);
            }

            filterDropdown.SelectedIndex = 0;
            filterDropdown.SelectedIndexChanged += FilterChanged;
        }

        private void LoadAppxPackages()
        {
            Task.Run(() =>
            {
                appxPackages.Clear();
                UpdateStatusLabel("Loading apps...");

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
                    while ((output = process.StandardOutput.ReadLine()) != null)
                    {
                        var parts = output.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length >= 1)
                        {
                            var appInfo = new AppInfo
                            {
                                Name = parts[0]
                            };
                            appxPackages.Add(appInfo);
                        }
                    }
                    process.WaitForExit();
                }

                Invoke(new Action(() =>
                {
                    UpdateStatusLabel($"{appxPackages.Count} apps installed");
                    ApplyFilter(filterDropdown.SelectedItem.ToString());
                }));
            });
        }

        private void UpdateStatusLabel(string message)
        {
            // Check if the current thread is the UI thread
            if (statusLabel.InvokeRequired)
            {
                // If not, marshal the update to the UI thread
                statusLabel.Invoke(new Action(() => UpdateStatusLabel(message)));
            }
            else
            {
                // If on the UI thread, update the label directly
                statusLabel.Text = message;
                statusLabel.Refresh();
            }
        }

        private void DisplayApps(List<AppInfo> apps)
        {
            checkedListBoxApps.Items.Clear();
            foreach (var app in apps)
            {
                checkedListBoxApps.Items.Add(app);
            }
        }

        private async Task RemoveApp(AppInfo app)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    // Update status label to show app being removed
                    UpdateStatusLabel($"Removing {app.Name}...");
                }));

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

                    // Read the standard output
                    string output = await process.StandardOutput.ReadToEndAsync();
                    if (!string.IsNullOrEmpty(output))
                    {
                        Invoke(new Action(() =>
                        {
                            UpdateStatusLabel(output);
                        }));
                    }

                    // Read the standard error
                    string errorOutput = await process.StandardError.ReadToEndAsync();
                    if (!string.IsNullOrEmpty(errorOutput))
                    {
                        Invoke(new Action(() =>
                        {
                            UpdateStatusLabel($"Error: {errorOutput}");
                            MessageBox.Show(
                                $"The app \"{app.Name}\" could not be removed. Check the error details.",
                                "App Removal Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }));

                        return;
                    }

                    await process.WaitForExitAsync();

                    Invoke(new Action(() =>
                    {
                        // Successfully removed
                        UpdateStatusLabel($"Successfully removed {app.Name}.");
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    // Handle removal error
                    UpdateStatusLabel($"Failed to remove {app.Name}: {ex.Message}");
                    MessageBox.Show(
                        $"An error occurred while removing \"{app.Name}\". Check the error details.",
                        "Unexpected Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }));
            }
        }

        private async void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            var selectedApps = checkedListBoxApps.CheckedItems.Cast<AppInfo>().ToList();
            if (!selectedApps.Any())
            {
                MessageBox.Show("No apps selected for removal.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var app in selectedApps)
            {
                await RemoveApp(app);
                checkedListBoxApps.Items.Remove(app);
            }

            MessageBox.Show($"{selectedApps.Count} app(s) removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCheckList_Click(object sender, EventArgs e)
        {
            bool shouldCheck = checkedListBoxApps.CheckedItems.Count < checkedListBoxApps.Items.Count;

            // Toggle all items
            for (int i = 0; i < checkedListBoxApps.Items.Count; i++)
            {
                checkedListBoxApps.SetItemChecked(i, shouldCheck);
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();
            var searchResults = displayedApps.Where(app => app.Name.ToLower().Contains(searchText)).ToList();
            DisplayApps(searchResults);
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (navigationManager.CanGoBack())
            {
                navigationManager.GoBack();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAppxPackages();
        }

    }
}

public static class ProcessExtensions
{
    public static async Task WaitForExitAsync(this Process process)
    {
        var tcs = new TaskCompletionSource<bool>();
        process.EnableRaisingEvents = true;
        process.Exited += (sender, args) => tcs.TrySetResult(true);
        await tcs.Task;
    }
}