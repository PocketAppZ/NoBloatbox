namespace Bloatboxer
{
    partial class AppsView
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
            this.btnBack = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.filterDropdown = new System.Windows.Forms.ComboBox();
            this.btnCheckList = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.checkedListBoxApps = new System.Windows.Forms.CheckedListBox();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnShare = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblDescriptionInfo = new System.Windows.Forms.Label();
            this.lblSourceInfo = new System.Windows.Forms.Label();
            this.borderDetails = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 30);
            this.btnBack.TabIndex = 232;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoEllipsis = true;
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(13, 47);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.statusLabel.Size = new System.Drawing.Size(184, 19);
            this.statusLabel.TabIndex = 262;
            this.statusLabel.Text = "No Bloatware file loaded";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filterDropdown
            // 
            this.filterDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.filterDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterDropdown.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F);
            this.filterDropdown.ForeColor = System.Drawing.Color.Black;
            this.filterDropdown.FormattingEnabled = true;
            this.filterDropdown.Location = new System.Drawing.Point(36, 0);
            this.filterDropdown.Name = "filterDropdown";
            this.filterDropdown.Size = new System.Drawing.Size(673, 30);
            this.filterDropdown.TabIndex = 244;
            this.filterDropdown.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.filterDropdown_DrawItem);
            // 
            // btnCheckList
            // 
            this.btnCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckList.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckList.FlatAppearance.BorderSize = 0;
            this.btnCheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckList.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnCheckList.ForeColor = System.Drawing.Color.Black;
            this.btnCheckList.Location = new System.Drawing.Point(760, 3);
            this.btnCheckList.Name = "btnCheckList";
            this.btnCheckList.Size = new System.Drawing.Size(36, 30);
            this.btnCheckList.TabIndex = 253;
            this.btnCheckList.TabStop = false;
            this.btnCheckList.Text = "...";
            this.btnCheckList.UseVisualStyleBackColor = false;
            this.btnCheckList.Click += new System.EventHandler(this.btnCheckList_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(715, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 30);
            this.btnRefresh.TabIndex = 249;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "...";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F);
            this.textBoxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSearch.Location = new System.Drawing.Point(334, 40);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(161, 26);
            this.textBoxSearch.TabIndex = 245;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // checkedListBoxApps
            // 
            this.checkedListBoxApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.checkedListBoxApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxApps.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10F);
            this.checkedListBoxApps.FormattingEnabled = true;
            this.checkedListBoxApps.Location = new System.Drawing.Point(29, 76);
            this.checkedListBoxApps.Name = "checkedListBoxApps";
            this.checkedListBoxApps.Size = new System.Drawing.Size(584, 520);
            this.checkedListBoxApps.Sorted = true;
            this.checkedListBoxApps.TabIndex = 250;
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveSelected.AutoEllipsis = true;
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnRemoveSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveSelected.FlatAppearance.BorderSize = 2;
            this.btnRemoveSelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnRemoveSelected.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSelected.Location = new System.Drawing.Point(20, 491);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(179, 38);
            this.btnRemoveSelected.TabIndex = 251;
            this.btnRemoveSelected.Text = "Remove selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelTop.Controls.Add(this.btnShare);
            this.panelTop.Controls.Add(this.btnCheckList);
            this.panelTop.Controls.Add(this.filterDropdown);
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.statusLabel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(844, 77);
            this.panelTop.TabIndex = 263;
            // 
            // btnShare
            // 
            this.btnShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShare.BackColor = System.Drawing.Color.Transparent;
            this.btnShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShare.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShare.FlatAppearance.BorderSize = 0;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnShare.ForeColor = System.Drawing.Color.Black;
            this.btnShare.Location = new System.Drawing.Point(811, 3);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(30, 30);
            this.btnShare.TabIndex = 269;
            this.btnShare.TabStop = false;
            this.btnShare.Text = "...";
            this.btnShare.UseVisualStyleBackColor = false;
            // 
            // lblSource
            // 
            this.lblSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSource.AutoEllipsis = true;
            this.lblSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(10, 70);
            this.lblSource.Name = "lblSource";
            this.lblSource.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblSource.Size = new System.Drawing.Size(187, 68);
            this.lblSource.TabIndex = 264;
            this.lblSource.Text = "Source";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(12, 202);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblDescription.Size = new System.Drawing.Size(187, 215);
            this.lblDescription.TabIndex = 265;
            this.lblDescription.Text = "Description";
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelDetails.Controls.Add(this.lblDescriptionInfo);
            this.panelDetails.Controls.Add(this.lblSourceInfo);
            this.panelDetails.Controls.Add(this.borderDetails);
            this.panelDetails.Controls.Add(this.lblDescription);
            this.panelDetails.Controls.Add(this.lblSource);
            this.panelDetails.Controls.Add(this.btnRemoveSelected);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDetails.Location = new System.Drawing.Point(630, 77);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(214, 547);
            this.panelDetails.TabIndex = 266;
            // 
            // lblDescriptionInfo
            // 
            this.lblDescriptionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescriptionInfo.AutoEllipsis = true;
            this.lblDescriptionInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDescriptionInfo.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescriptionInfo.Location = new System.Drawing.Point(11, 167);
            this.lblDescriptionInfo.Name = "lblDescriptionInfo";
            this.lblDescriptionInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDescriptionInfo.Size = new System.Drawing.Size(187, 33);
            this.lblDescriptionInfo.TabIndex = 270;
            this.lblDescriptionInfo.Text = "Description";
            this.lblDescriptionInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSourceInfo
            // 
            this.lblSourceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSourceInfo.AutoEllipsis = true;
            this.lblSourceInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblSourceInfo.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.lblSourceInfo.Location = new System.Drawing.Point(10, 34);
            this.lblSourceInfo.Name = "lblSourceInfo";
            this.lblSourceInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblSourceInfo.Size = new System.Drawing.Size(187, 33);
            this.lblSourceInfo.TabIndex = 267;
            this.lblSourceInfo.Text = "Source";
            this.lblSourceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // borderDetails
            // 
            this.borderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.borderDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.borderDetails.Location = new System.Drawing.Point(3, 0);
            this.borderDetails.Name = "borderDetails";
            this.borderDetails.Size = new System.Drawing.Size(2, 548);
            this.borderDetails.TabIndex = 266;
            // 
            // AppsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.checkedListBoxApps);
            this.Name = "AppsView";
            this.Size = new System.Drawing.Size(844, 624);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox filterDropdown;
        private System.Windows.Forms.Button btnCheckList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.CheckedListBox checkedListBoxApps;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Label borderDetails;
        private System.Windows.Forms.Label lblSourceInfo;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.Label lblDescriptionInfo;
    }
}
