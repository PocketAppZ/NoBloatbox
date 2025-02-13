using Bloatboxer.Views;
using Helper;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bloatboxer
{
    public partial class MainForm : Form
    {
        private LoggerForm loggerForm;
        private NavigationManager navigationManager;
        private string lastLoadedFilterPath;
        private string pluginsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins");

        public MainForm()
        {
            InitializeComponent();
            navigationManager = new NavigationManager(panelContainer);
            InitializeUI();
            LoadFiltersIntoDropdown();

        }

        private void InitializeUI()
        {
            // Set the Segoe MDL2 Assets font for the icons
            btnConfirmFilter.Text = "\uE761";              // Forward icon
            btnMore.Text = "\uE712";                       // More icon
            assetUpload.Text = "\uE74B";                  // Drag and drop icon
            assetChevronRightAppsFilter.Text =
            assetChevronRighStore.Text = "\uE76C";       // Forward icon
            btnAbout.Text = "\uF167";                   // Info icon

            // Set the event handlers for the buttons
            btnAppsFilter.Click += (s, e) => { navigationManager.SwitchView(new AppsFilterView(navigationManager)); };
            btnPlugins.Click += (s, e) => { navigationManager.SwitchView(new PluginsView(navigationManager)); };
            btnAbout.Click += (s, e) => { using (AboutForm aboutForm = new AboutForm()) { ShowAndDim(aboutForm, true); } };
            linkClose.Click += (s, e) => { Close(); };  
            linkGitHub.Click += (s, e) => { Process.Start("https://github.com/builtbybel/Bloatboxer"); };


            // Load the desktop wallpaper to panelDragDrop
            try
            {
                string wallpaperPath = Utils.GetDesktopWallpaper();
                if (!string.IsNullOrWhiteSpace(wallpaperPath))
                    pictureWallpaper.Image = Image.FromFile(wallpaperPath);
            }
            catch (Exception ex)
            {
                UpdateStatusLabel($"Error loading Wallpaper: {ex.Message}");
            }
        }

        private void LoadFiltersIntoDropdown()
        {
            // Define plugin directory and create it if missing
            Directory.CreateDirectory(pluginsDir);

            // Fetch filter files with Bloatwrae '_*.json' pattern
            var filterFiles = Directory.EnumerateFiles(pluginsDir, "_*.json")
                                        .Select(Path.GetFileNameWithoutExtension);

            // Clear dropdown and add initial options
            filterDropdown.Items.Clear();
            filterDropdown.Items.AddRange(new[] { "Filter" }
                .Concat(filterFiles) // Add all found filters
                .Append("Open Plugins") // Add More Plugins option
                .ToArray());

            // Set default selection
            filterDropdown.SelectedIndex = 0;
        }

        private void filterDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item, exit if invalid
            string selectedItem = filterDropdown.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedItem) || selectedItem == "Filter") return;

            // Handle "Open Plugins" navigation
            if (selectedItem == "Open Plugins")
            {
                navigationManager.SwitchView(new PluginsView(navigationManager));
                return;
            }

            // Locate the plugin directory and filter file
            string selectedFilePath = Directory.EnumerateFiles(pluginsDir, "_*.json")
                                                .FirstOrDefault(file => Path.GetFileNameWithoutExtension(file) == selectedItem);

            // Load the selected filter if found
            if (selectedFilePath != null)
            {
                var appsView = new AppsView(navigationManager);
                _ = appsView.LoadFilters(selectedFilePath); // Load filter in AppsView
                navigationManager.SwitchView(appsView); // Navigate to Apps view
                lastLoadedFilterPath = selectedFilePath; // Remember last loaded filter
                UpdateStatusLabel($"Loaded signature file '{selectedItem}'.");
            }
        }

        private void filterDropdown_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Draw background and handle focus
            e.DrawBackground();

            // Add padding 
            int padding = 30;

            // Draw the item text
            string text = filterDropdown.Items[e.Index].ToString();
            e.Graphics.DrawString(text, e.Font, new SolidBrush(e.ForeColor), e.Bounds.X + padding, e.Bounds.Y);

            e.DrawFocusRectangle();
        }

        // Dash pattern for the border
        private void panelDragDrop_Paint(object sender, PaintEventArgs e)
        {
            // Array of colors for the border
            var colors = new[]
            {
            Color.Magenta,
            Color.LimeGreen,
            Color.HotPink,
            Color.Orchid,
            Color.DarkOrchid,
            Color.Purple,
            Color.OrangeRed,
            Color.Black,
            Color.FromArgb(0, 62, 146) // Blue
        };

            // Dynamically select a color based on the current second
            var borderColor = colors[DateTime.Now.Second % colors.Length];
            var borderThickness = 1;

            // Set the color of the buttons to match the border
            btnAbout.ForeColor = 
            linkClose.BackColor =
            linkGitHub.LinkColor = borderColor;

            // Longer dashes (20) and spaced out (10)
            var dashPattern = new float[] { 20, 10 };

            using (var pen = new Pen(borderColor, borderThickness))
            {
                // Apply the dash pattern
                pen.DashPattern = dashPattern;
                pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                // Define the rectangle for the border
                var rect = new Rectangle(
                    borderThickness / 2,
                    borderThickness / 2,
                    panelDragDrop.Width - borderThickness,
                    panelDragDrop.Height - borderThickness
                );

                // Enable anti-aliasing for smoother visuals
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void panelDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                {
                    string extension = Path.GetExtension(files[0]).ToLowerInvariant();
                    if (extension == ".json" || extension == ".ps1")
                    {
                        e.Effect = DragDropEffects.Copy;
                        return;
                    }
                }
            }

            e.Effect = DragDropEffects.None;
        }

        // Handle file drop
        private void ProcessFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLowerInvariant();
            string fileName = Path.GetFileName(filePath);

            // Validate file extension
            if (extension != ".json" && extension != ".ps1")
            {
                UpdateStatusLabel("Unsupported file format. Please select a .json or .ps1 file.");
                return;
            }

            IsPluginEnvironmentReady();

            if (extension == ".json" && fileName.Contains("_"))
            {
                // If the JSON file follows the "_" naming convention, load it as a filter
                var appsView = new AppsView(navigationManager);
                _ = appsView.LoadFilters(filePath);
                navigationManager.SwitchView(appsView);
                lastLoadedFilterPath = filePath;
                UpdateStatusLabel($"Bloatware file '{fileName}' loaded.");
            }
            else
            {
                // Move other JSON and PS1 files to the Plugins directory
                string destinationPath = Path.Combine("Plugins", fileName);
                File.Copy(filePath, destinationPath, true);
                File.Delete(filePath);
                navigationManager.SwitchView(new PluginsView(navigationManager));
                UpdateStatusLabel($"File '{fileName}' successfully added to Plugins.");
            }
        }

        // Handle drag & drop event
        private void panelDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (!(e.Data.GetData(DataFormats.FileDrop) is string[] files) || files.Length != 1) return;
            ProcessFile(files[0]); // Call the common file processing method
        }

        // Handle file selection via More button
        private void btnMore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json|PowerShell Scripts (*.ps1)|*.ps1";
                openFileDialog.Title = "Select a file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ProcessFile(openFileDialog.FileName); // Call the common file processing method
                }
            }
        }

        // Create the Plugins environment if missing
        private void IsPluginEnvironmentReady()
        {
            string pluginDir = "Plugins";

            if (!Directory.Exists(pluginDir))
            {
                Directory.CreateDirectory(pluginDir);
                UpdateStatusLabel($"Created missing plugin directory: {pluginDir}");
            }
        }

        // Update the status label with the given message
        private void UpdateStatusLabel(string message)
        {
            statusLabel.Text = message;
            statusLabel.Refresh();
        }

        // Reload the last loaded filter file
        private void btnReloadFilter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastLoadedFilterPath) && File.Exists(lastLoadedFilterPath))
            {
                var appsView = new AppsView(navigationManager);
                _ = appsView.LoadFilters(lastLoadedFilterPath);
                navigationManager.SwitchView(appsView);
                UpdateStatusLabel($"Reloaded filter file from '{lastLoadedFilterPath}'.");
            }
            else
            {
                UpdateStatusLabel("No valid filter file to reload.");
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            ConnectForm storeForm = new ConnectForm();
            this.Opacity = 0.9;
            storeForm.FormClosed += (s, args) => this.Opacity = 1.0;
            storeForm.ShowDialog();
        }

        // Show the form and dim the MainForm
        private void ShowAndDim(Form form, bool isModal = false)
        {
            this.Opacity = 0.9;

            if (isModal)
            {
                form.FormClosed += (s, e) => this.Opacity = 1;
                form.ShowDialog();
            }
            else
            {
                form.Show();
            }
        }

        private LoggerForm CreateLoggerForm()
        {
            if (loggerForm == null)
            {
                loggerForm = new LoggerForm();
                Logger.SetLoggerForm(loggerForm); // Set the LoggerForm instance for logging

                loggerForm.Deactivate += (s, e) =>
                {
                    // Hide the LoggerForm when it loses focus
                    loggerForm.Hide();
                    this.Opacity = 1; // Reset the opacity of the MainForm
                };
            }
            return loggerForm;
        }

        // Toggle the visibility of the LoggerForm
        public void ToggleLoggerForm()
        {
            if (loggerForm == null)
            {
                // Create the LoggerForm if it does not already exist
                loggerForm = CreateLoggerForm();
            }

            if (loggerForm.Visible)
            {
                loggerForm.Hide();
                this.Opacity = 1; // Reset the opacity of the MainForm
            }
            else
            {
                ShowAndDim(loggerForm);
            }
        }

    
    }
}