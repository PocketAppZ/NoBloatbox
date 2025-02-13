using Bloatboxer.Views;
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

namespace Bloatboxer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            assetApp.Text = "\uECAA";                   // Apps icon
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/builtbybel/Bloatboxer");
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/builtbybel/Bloatboxer?tab=readme-ov-file#how-does-it-work");
        }

        private void btnAllApps_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/builtbybel");
        }

        private void btnHub_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
         Helper.Utils.CheckForAppUpdates();
        }
    }
}