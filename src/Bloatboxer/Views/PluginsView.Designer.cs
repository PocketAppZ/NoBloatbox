namespace Bloatboxer.Views
{
    partial class PluginsView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelPlugins = new System.Windows.Forms.Panel();
            this.treePlugins = new System.Windows.Forms.TreeView();
            this.lblInstalled = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnPluginsDir = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(24, 23);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(595, 39);
            this.lblHeader.TabIndex = 313;
            this.lblHeader.Text = "Plugins";
            // 
            // panelPlugins
            // 
            this.panelPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlugins.Controls.Add(this.treePlugins);
            this.panelPlugins.Controls.Add(this.lblInstalled);
            this.panelPlugins.Location = new System.Drawing.Point(40, 60);
            this.panelPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.panelPlugins.Name = "panelPlugins";
            this.panelPlugins.Size = new System.Drawing.Size(763, 477);
            this.panelPlugins.TabIndex = 312;
            // 
            // treePlugins
            // 
            this.treePlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePlugins.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treePlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treePlugins.CheckBoxes = true;
            this.treePlugins.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 10.75F);
            this.treePlugins.ForeColor = System.Drawing.Color.Black;
            this.treePlugins.FullRowSelect = true;
            this.treePlugins.HotTracking = true;
            this.treePlugins.ItemHeight = 22;
            this.treePlugins.Location = new System.Drawing.Point(19, 56);
            this.treePlugins.Margin = new System.Windows.Forms.Padding(4);
            this.treePlugins.Name = "treePlugins";
            this.treePlugins.ShowLines = false;
            this.treePlugins.ShowNodeToolTips = true;
            this.treePlugins.ShowPlusMinus = false;
            this.treePlugins.Size = new System.Drawing.Size(735, 406);
            this.treePlugins.TabIndex = 256;
            this.treePlugins.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treePlugins_AfterCheck);
            // 
            // lblInstalled
            // 
            this.lblInstalled.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 11F, System.Drawing.FontStyle.Bold);
            this.lblInstalled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInstalled.Location = new System.Drawing.Point(15, 16);
            this.lblInstalled.Margin = new System.Windows.Forms.Padding(4);
            this.lblInstalled.Name = "lblInstalled";
            this.lblInstalled.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblInstalled.Size = new System.Drawing.Size(109, 32);
            this.lblInstalled.TabIndex = 260;
            this.lblInstalled.Text = "Installed";
            this.lblInstalled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(688, 559);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 31);
            this.btnNext.TabIndex = 311;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.75F);
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnImport.Location = new System.Drawing.Point(626, 20);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(93, 30);
            this.btnImport.TabIndex = 317;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPluginsDir
            // 
            this.btnPluginsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPluginsDir.BackColor = System.Drawing.Color.Transparent;
            this.btnPluginsDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPluginsDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnPluginsDir.FlatAppearance.BorderSize = 0;
            this.btnPluginsDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPluginsDir.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnPluginsDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnPluginsDir.Location = new System.Drawing.Point(725, 20);
            this.btnPluginsDir.Name = "btnPluginsDir";
            this.btnPluginsDir.Size = new System.Drawing.Size(36, 30);
            this.btnPluginsDir.TabIndex = 316;
            this.btnPluginsDir.TabStop = false;
            this.btnPluginsDir.Text = "...";
            this.btnPluginsDir.UseMnemonic = false;
            this.btnPluginsDir.UseVisualStyleBackColor = false;
            this.btnPluginsDir.Click += new System.EventHandler(this.btnPluginsDir_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnRefresh.Location = new System.Drawing.Point(767, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 30);
            this.btnRefresh.TabIndex = 315;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "...";
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnBack.Location = new System.Drawing.Point(565, 559);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 31);
            this.btnBack.TabIndex = 319;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PluginsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelPlugins);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnPluginsDir);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblHeader);
            this.Name = "PluginsView";
            this.Size = new System.Drawing.Size(844, 624);
            this.Load += new System.EventHandler(this.PluginsView_Load);
            this.panelPlugins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelPlugins;
        private System.Windows.Forms.TreeView treePlugins;
        private System.Windows.Forms.Label lblInstalled;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnPluginsDir;
        public System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
    }
}
