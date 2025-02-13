﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace Bloatboxer.Views
{
    public partial class PluginsView : UserControl
    {
        private Logger logger;
        private PSPluginHandler PSPlugins;
        private NavigationManager navigationManager;
        private Dictionary<TreeNode, bool> pendingChanges = new Dictionary<TreeNode, bool>();
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string pluginsDirectory = Path.Combine(Application.StartupPath, "plugins");

        public PluginsView(NavigationManager navigationManager)
        {
            InitializeComponent();
            InitializeLogger();
            this.navigationManager = navigationManager;

            btnPluginsDir.Text = "\uED25"; // Folder icon
            btnRefresh.Text = "\uE72C"; // Refresh icon
        }

        private void PluginsView_Load(object sender, EventArgs e)
        {
            LoadPlugins();
        }

        private void InitializeLogger()
        {
            logger = new Logger();
        }

        public async void LoadPlugins()
        {
            // Load native JSON plugins
            await JsonPluginHandler.LoadPlugins("plugins", treePlugins.Nodes, logger);
            logger.Log("Plugins [Native] initialized.", Color.Green);

            // Load PowerShell plugins
            PSPlugins = new PSPluginHandler();
            PSPlugins.LoadPowerShellPlugins(treePlugins);
            logger.Log("Plugins [PS] initialized.", Color.Green);

            // Expand all nodes
            ExpandAllNodes(treePlugins.Nodes);
        }

        private void ExpandAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Expand();
                ExpandAllNodes(node.Nodes);
            }
        }

        private void treePlugins_AfterCheck(object sender, TreeViewEventArgs e)
        {
            var node = e.Node;
            bool shouldApply = node.Checked;

            pendingChanges[node] = shouldApply;
            node.BackColor = shouldApply ? Color.LimeGreen : Color.PaleVioletRed;

            if (node.Tag is JsonPluginHandler jsonPlugin)
            {
                logger.Log($"{(shouldApply ? "Activated" : "Deactivated")} Plugin: {jsonPlugin.PlugID}", shouldApply ? Color.Black : Color.Crimson);
            }
            else if (node.Tag is string psScriptPath)
            {
                logger.Log($"{(shouldApply ? "Activated" : "Deactivated")} PowerShell script: {Path.GetFileName(psScriptPath)}", shouldApply ? Color.Black : Color.Crimson);
            }
        }

        // Refresh the tree view
        public void RefreshPlugins()
        {
            treePlugins.Nodes.Clear();

            // Reload
            LoadPlugins();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPlugins();
        }

        private void btnPluginsDir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", pluginsDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open plugins directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceDirectory = folderBrowserDialog.SelectedPath;
                    string[] files = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.TopDirectoryOnly)
                        .Where(file => file.EndsWith(".json") || file.EndsWith(".ps1")).ToArray();

                    List<string> importedPlugins = new List<string>(); // List to store imported plugin names

                    foreach (var file in files)
                    {
                        try
                        {
                            string fileName = Path.GetFileName(file);
                            string destinationPath = Path.Combine(pluginsDirectory, fileName);
                            File.Copy(file, destinationPath, true); // Overwrite if file exists
                            importedPlugins.Add(fileName); // Add to the imported plugins list
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to import {file}: {ex.Message}");
                        }
                    }

                    // Show imported plugins
                    if (importedPlugins.Count > 0)
                    {
                        string message = "Imported Plugins:\n" + string.Join("\n", importedPlugins);
                        MessageBox.Show(message, "Import Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No plugins were imported.", "Import Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Switch to companionReview
            var companionReview = new PluginsReview(navigationManager, pendingChanges, logger, PSPlugins);
            navigationManager.SwitchView(companionReview); // Switch view using the shared NavigationManager
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (navigationManager.CanGoBack()) // Check if there is a view to go back to
            {
                navigationManager.GoBack();
            }
        }
    }
}