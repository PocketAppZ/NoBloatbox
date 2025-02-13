using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Bloatboxer
{
    public partial class LoggerForm : Form
    {
        public LoggerForm()
        {
            InitializeComponent();
        }

        // Log to the RichTextBox
        public void AddLog(string message, Color color)
        {
            if (rtbLog.InvokeRequired)
            {
                // Invoke on the UI thread
                rtbLog.Invoke(new Action(() => AddLog(message, color)));
            }
            else
            {
                // Perform changes directly on the UI thread
                rtbLog.SelectionColor = color;
                rtbLog.AppendText(message + Environment.NewLine);
                rtbLog.ScrollToCaret();
            }
        }

        private void rtbLog_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = e.LinkText,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}