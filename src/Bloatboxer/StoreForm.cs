using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloatboxer
{
    public partial class ConnectForm : Form
    {
        private string PluginJsonUrl;
        private string PluginBaseUrl;

        private Dictionary<string, string> pluginDescriptions;
        private readonly string pluginsDirectory = Path.Combine(Application.StartupPath, "plugins");

        private Label toastLabel;

        // Mapping of repository names to their corresponding GitHub paths
        private readonly Dictionary<string, string> repoMappings = new Dictionary<string, string>
        {
            { "Bloatboxer", "builtbybel/Bloatboxer" },
            { "Bloatynosy", "builtbybel/BloatyNosy" }
        };

        private void SetRepoUrls(string repoName)
        {
            if (repoMappings.TryGetValue(repoName, out string repoPath))
            {
                PluginJsonUrl = $"https://raw.githubusercontent.com/{repoPath}/main/plugins/plugins_manifest.json";
                PluginBaseUrl = $"https://github.com/{repoPath}/raw/main/plugins/";
            }
        }

        public ConnectForm()

        {
            InitializeComponent();
            InitializeToastLabel();
            InitializeRepoSelector();
            SetRepoUrls("Bloatboxer"); // Set default repo
            LoadPlugins();
        }

        private void InitializeRepoSelector()
        {
            comboBoxRepoSelector.Items.AddRange(repoMappings.Keys.ToArray());
            comboBoxRepoSelector.SelectedIndex = 0;
            comboBoxRepoSelector.SelectedIndexChanged += (s, e) =>
            {
                string selectedRepo = comboBoxRepoSelector.SelectedItem.ToString();
                SetRepoUrls(selectedRepo);
                LoadPlugins();
            };

            Controls.Add(comboBoxRepoSelector);
            comboBoxRepoSelector.BringToFront();
        }

        private async void LoadPlugins()
        {
            // Display Loading message
            var loadingLabel = new Label
            {
                Text = "Loading...",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(205, 0, 123),
                AutoSize = false,
                Width = flowLayoutPanelPlugins.Width,
                Height = 50
            };
            flowLayoutPanelPlugins.Controls.Add(loadingLabel);

            try
            {
                var json = await DownloadJson(PluginJsonUrl);
                pluginDescriptions = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                var pluginControls = new List<Control>(); // Temporary list to store plugin controls

                foreach (var plugin in pluginDescriptions)
                {
                    string pluginFileName = plugin.Key;
                    string description = plugin.Value;
                    bool isInstalled = File.Exists(Path.Combine(pluginsDirectory, pluginFileName));

                    // Create plugin control and add to the list
                    var pluginControl = CreatePluginControl(pluginFileName, description, isInstalled);
                    pluginControls.Add(pluginControl);
                }

                // Remove the loading message
                flowLayoutPanelPlugins.Controls.Clear();

                // Add all plugin controls at once
                flowLayoutPanelPlugins.Controls.AddRange(pluginControls.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading plugins: {ex.Message}");
            }
        }

        private Control CreatePluginControl(string pluginFileName, string description, bool isInstalled)
        {
            // Panel to contain the plugin information
            var panel = new Panel
            {
                Width = 350,
                Height = 200,
                AutoScroll = true,
                BackColor = Color.Violet,
                Margin = new Padding(15),
                Padding = new Padding(10),
                ForeColor = Color.Black,
            };

            // Label for the plugin name
            var lblPluginName = new Label
            {
                Text = pluginFileName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                // Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleLeft,
                MinimumSize = new Size(300, 20),
                AutoEllipsis = true,
                Height = 40
            };

            // Label for the description
            var lblDescription = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 9),
                Dock = DockStyle.Bottom,
                MinimumSize = new Size(280, 50),
                AutoEllipsis = true,
            };

            // Install button
            var btnInstall = new Button
            {
                AutoSize = true,
                Text = isInstalled ? "Update" : "Install",
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, BorderColor = Color.DimGray },
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Dock = DockStyle.Bottom,
                BackColor = Color.Plum,
                Tag = pluginFileName
            };

            btnInstall.Click += async (s, e) => await InstallPlugin(pluginFileName, btnInstall);

            // Uninstall button (only if installed)
            var btnUninstall = new Button
            {
                AutoSize = true,
                Text = "Remove",
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, BorderColor = Color.DimGray },
                Font = new Font("Segoe UI", 9),
                Dock = DockStyle.Bottom,
                BackColor = Color.DimGray,
                ForeColor = Color.FromArgb(221, 221, 221),
                Tag = pluginFileName,
                Visible = isInstalled
            };

            btnUninstall.Click += (s, e) => UninstallPlugin(pluginFileName, btnInstall, btnUninstall);

            // Details button
            var btnDetails = new Button
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Text = "\u2026", // Ellipsis for 3 dots
                Font = new Font("Segoe MDL2 Assets", 18), // Icon font
                FlatStyle = FlatStyle.Flat,
                Width = 35,
                Height = 35,
                TextAlign = ContentAlignment.MiddleCenter
            };
            btnDetails.FlatAppearance.BorderSize = 0;
            btnDetails.FlatAppearance.MouseOverBackColor = Color.DarkMagenta;
            btnDetails.Click += (s, e) => OpenPluginDetails(pluginFileName);
            //btnDetails.Click += (s, e) => ShowPluginDetails(pluginFileName, description);

            // Position the button at the top-right of the panel
            btnDetails.Location = new Point(panel.Width - btnDetails.Width);

            // Add Tooltip
            new ToolTip().SetToolTip(btnDetails, "Info about this Plugin");

            // Add controls to panel
            panel.Controls.Add(lblPluginName);
            panel.Controls.Add(lblDescription);
            panel.Controls.Add(btnInstall);
            panel.Controls.Add(btnDetails);
            panel.Controls.Add(btnUninstall);

            return panel;
        }

        // Toast message
        private void InitializeToastLabel()
        {
            toastLabel = new Label
            {
                AutoSize = true,
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(27, 102, 25),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Visible = false,
                Padding = new Padding(10),
            };
            Controls.Add(toastLabel);
            toastLabel.BringToFront();
        }

        private void ShowToast(string message)
        {
            toastLabel.Text = message;
            toastLabel.Visible = true;

            // Auto-hide the toast after 3 sec
            var timer = new Timer { Interval = 3000 };
            timer.Tick += (s, e) =>
            {
                toastLabel.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }

        private async Task InstallPlugin(string pluginFileName, Button installButton)
        {
            try
            {
                string pluginUrl = $"{PluginBaseUrl}{pluginFileName}";
                string downloadPath = Path.Combine(pluginsDirectory, pluginFileName);

                // Create Plugin directory if it doesn't exist
                if (!Directory.Exists(pluginsDirectory))
                {
                    Directory.CreateDirectory(pluginsDirectory);
                }

                using (HttpClient client = new HttpClient())
                {
                    var data = await client.GetByteArrayAsync(pluginUrl);
                    await WriteAllBytes(downloadPath, data);
                }

                ShowToast($"{pluginFileName} has been installed."); // Toast message
                installButton.Text = "Update";

                var uninstallButton = installButton.Parent.Controls.OfType<Button>().First(b => b.Text == "Remove");
                uninstallButton.Visible = true;
            }
            catch (Exception ex)
            {
                ShowToast($"Failed to install {pluginFileName}: {ex.Message}");
            }
        }

        private void UninstallPlugin(string pluginFileName, Button installButton, Button uninstallButton)
        {
            try
            {
                string filePath = Path.Combine(pluginsDirectory, pluginFileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    ShowToast($"{pluginFileName} has been uninstalled."); // Toast message
                    installButton.Text = "Install";
                    uninstallButton.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ShowToast($"Failed to uninstall {pluginFileName}: {ex.Message}");
            }
        }

        private void FilterPlugins(string searchTerm)
        {
            // Clear the existing plugins from the panel
            flowLayoutPanelPlugins.Controls.Clear();

            // Filter the plugins based on search term
            var filteredPlugins = pluginDescriptions
                .Where(plugin =>
                    plugin.Key.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    plugin.Value.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            // Create and add controls for each filtered plugin
            var pluginControls = filteredPlugins.Select(plugin =>
            {
                string pluginFileName = plugin.Key;
                string description = plugin.Value;
                bool isInstalled = File.Exists(Path.Combine(pluginsDirectory, pluginFileName));
                return CreatePluginControl(pluginFileName, description, isInstalled);
            }).ToList();

            // Add filtered plugin controls to the panel
            flowLayoutPanelPlugins.Controls.AddRange(pluginControls.ToArray());
        }

        private void ShowPluginDetails(string pluginFileName, string description)
        {
            MessageBox.Show($"Plugin: {pluginFileName}\n\nDescription:\n{description}", "Plugin Details",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenPluginDetails(string pluginFileName)
        {
            string pluginUrl = $"https://github.com/builtbybel/Bloatboxer/blob/main/plugins/{pluginFileName}";
            Process.Start(new ProcessStartInfo
            {
                FileName = pluginUrl,
                UseShellExecute = true
            });

            ShowToast($"Opening {pluginFileName} plugin in browser.");
        }

        private async Task<string> DownloadJson(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        private async Task WriteAllBytes(string path, byte[] data)
        {
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
            {
                await fs.WriteAsync(data, 0, data.Length);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch.Text.Trim();
            FilterPlugins(searchTerm);
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = string.Empty;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pluginStoreUrl = $"https://github.com/builtbybel/Bloatboxer/blob/main/plugins";
            Process.Start(new ProcessStartInfo
            {
                FileName = pluginStoreUrl,
                UseShellExecute = true
            });
        }
    }
}