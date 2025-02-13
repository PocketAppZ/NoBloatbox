﻿using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloatboxer
{
    public class JsonPluginHandler
    {
        public string PlugID { get; set; }
        public string PlugInfo { get; set; }
        public string[] PlugCheck { get; set; }
        public string[] PlugDo { get; set; }
        public string[] PlugUndo { get; set; }
        public string PlugCategory { get; set; }
        public bool? PlugDefaultState { get; set; }

        private Logger logger;

        public JsonPluginHandler(Logger logger)
        {
            this.logger = logger;
        }

        public bool PlugCheckFeature()
        {
            bool isFeatureActive = true;
            foreach (var command in PlugCheck)
            {
                if (!ExecuteCommandAndCheckResult(command))
                {
                    isFeatureActive = false;
                    break;
                }
            }
            logger.Log($"Feature '{PlugID}' is {(isFeatureActive ? "active" : "inactive")}", System.Drawing.Color.Black);
            return isFeatureActive;
        }

        // PlugCheck Helper to execute commands and check the result
        private bool ExecuteCommandAndCheckResult(string command)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c {command}",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    }
                };
                process.Start();
                process.WaitForExit();

                // Read the output of the command
                string output = process.StandardOutput.ReadToEnd();

                // Check if output contains "1" (indicating active) or "0" (indicating inactive)
                bool isActive = output.Contains("1");

                // logger.Log($"Plugin executed successfully: {command}. Result: {(isActive ? "active" : "inactive")}", System.Drawing.Color.Black);
                return isActive;
            }
            catch (Exception ex)
            {
                logger.Log($"Error executing plugin: {command}. Exception: {ex.Message}", System.Drawing.Color.Crimson);
                return false;
            }
        }

        public async void PlugDoFeature()
        {
            await ExecuteFeatureCommands(PlugDo);
        }

        public async void PlugUndoFeature()
        {
            await ExecuteFeatureCommands(PlugUndo);
        }

        private async Task ExecuteFeatureCommands(string[] commands)
        {
            foreach (var command in commands)
            {
                await ExecuteCommand(command);
            }
        }

        private async Task ExecuteCommand(string command)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = IsPowerShellCommand(command) ? "powershell.exe" : "cmd.exe",
                        Arguments = IsPowerShellCommand(command) ? $"-Command \"{command}\"" : $"/c \"{command}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                    }
                };

                // Event handler for handling output data
                process.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        logger.Log($"Output: {e.Data}", System.Drawing.Color.Green);
                    }
                };

                // Event handler for handling error data
                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        logger.Log($"Error: {e.Data}", System.Drawing.Color.Crimson);
                    }
                };

                process.Start();

                // Begin asynchronous reading of the output and error streams
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // Wait for the process to exit
                await process.WaitForExitAsync();

                // Log command execution
                logger.Log($"Plugin executed command: {command}", System.Drawing.Color.Green);
            }
            catch (Exception ex)
            {
                logger.Log($"Error executing plugin: {command}. Exception: {ex.Message}", System.Drawing.Color.Crimson);
            }
        }

        // Determine if command should be run with Ps
        private bool IsPowerShellCommand(string command)
        {
            return command.StartsWith("powershell.exe") || command.Contains("Get-") || command.Contains("Set-");
        }

        // Get plugin information
        public string GetPluginInformation()
        {
            return $"{PlugInfo.Replace("\\n", Environment.NewLine)}";
        }

        private static void AddToPluginCategory(TreeNodeCollection pluginCategory, TreeNode node, string category)
        {
            if (pluginCategory == null)
                throw new ArgumentNullException(nameof(pluginCategory));
            var existingCategory = pluginCategory.Cast<TreeNode>().FirstOrDefault(n => n.Text == category);

            if (existingCategory == null)
            {
                existingCategory = new TreeNode(category)
                {
                    BackColor = System.Drawing.Color.LightBlue,
                    ForeColor = System.Drawing.Color.Black
                };
                pluginCategory.Add(existingCategory);
            }

            existingCategory.Nodes.Add(node);
        }

        public static async Task LoadPlugins(string pluginDirectory, TreeNodeCollection pluginCategory, Logger logger)
        {
            if (Directory.Exists(pluginDirectory))
            {
                var pluginFiles = Directory.GetFiles(pluginDirectory, "*.json");

                foreach (var file in pluginFiles)
                {
                    // Exclude bloatware filter files starting with "_"
                    var fileName = Path.GetFileName(file);
                    if (fileName.StartsWith("_", StringComparison.OrdinalIgnoreCase) &&
                        fileName.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    try
                    {
                        var json = File.ReadAllText(file);
                        var plugin = JsonConvert.DeserializeObject<JsonPluginHandler>(json);

                        if (plugin != null)
                        {
                            plugin.logger = logger; // Set logger for the plugin

                            // Execute PlugCheck if available
                            bool isActive = false;
                            if (plugin.PlugCheck != null && plugin.PlugCheck.Any())
                            {
                                isActive = plugin.PlugCheckFeature();
                            }
                            else if (plugin.PlugDefaultState.HasValue)
                            {
                                // Use PlugDefaultState if no PlugCheck is defined
                                isActive = plugin.PlugDefaultState.Value;
                            }

                            var pluginNode = new TreeNode(plugin.PlugID)
                            {
                                ToolTipText = plugin.PlugInfo,
                                Checked = isActive,
                                Tag = plugin // Store plugin object in Tag property
                            };

                            // Add to the appropriate category
                            AddToPluginCategory(pluginCategory, pluginNode, plugin.PlugCategory);
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Log($"Error loading plugin from file '{file}': {ex.Message}", System.Drawing.Color.Crimson);
                    }
                }
            }
        }
    }
}