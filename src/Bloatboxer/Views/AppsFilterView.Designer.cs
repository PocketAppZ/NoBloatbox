namespace Bloatboxer
{
    partial class AppsFilterView
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
            this.checkedListBoxApps = new System.Windows.Forms.CheckedListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.linkSelect = new System.Windows.Forms.LinkLabel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxApps
            // 
            this.checkedListBoxApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.checkedListBoxApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxApps.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10F);
            this.checkedListBoxApps.FormattingEnabled = true;
            this.checkedListBoxApps.Location = new System.Drawing.Point(22, 240);
            this.checkedListBoxApps.Name = "checkedListBoxApps";
            this.checkedListBoxApps.Size = new System.Drawing.Size(784, 302);
            this.checkedListBoxApps.Sorted = true;
            this.checkedListBoxApps.TabIndex = 251;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoEllipsis = true;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(627, 558);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(179, 38);
            this.btnRemove.TabIndex = 252;
            this.btnRemove.Text = "Remove selected";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AutoEllipsis = true;
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.25F);
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(22, 168);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(134, 33);
            this.btnCheck.TabIndex = 253;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // textFilter
            // 
            this.textFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilter.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFilter.Location = new System.Drawing.Point(22, 75);
            this.textFilter.Multiline = true;
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(784, 79);
            this.textFilter.TabIndex = 1;
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10F);
            this.linkBack.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.linkBack.Location = new System.Drawing.Point(179, 177);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(49, 19);
            this.linkBack.TabIndex = 313;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Cancel";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10.5F);
            this.lblHeader.ForeColor = System.Drawing.Color.DimGray;
            this.lblHeader.Location = new System.Drawing.Point(18, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(788, 55);
            this.lblHeader.TabIndex = 314;
            this.lblHeader.Text = "Enter app names to search and filter installed applications. Wildcards are suppor" +
    "ted automatically—no special characters required. List multiple app names by sep" +
    "arating them with new lines.";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkSelect
            // 
            this.linkSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkSelect.AutoSize = true;
            this.linkSelect.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 10F);
            this.linkSelect.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSelect.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.linkSelect.Location = new System.Drawing.Point(18, 558);
            this.linkSelect.Name = "linkSelect";
            this.linkSelect.Size = new System.Drawing.Size(62, 19);
            this.linkSelect.TabIndex = 315;
            this.linkSelect.TabStop = true;
            this.linkSelect.Text = "Select All";
            this.linkSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelect_LinkClicked);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.AutoEllipsis = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F);
            this.statusLabel.Location = new System.Drawing.Point(605, 171);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(201, 30);
            this.statusLabel.TabIndex = 316;
            this.statusLabel.Text = "Idle";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AppsFilterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.linkSelect);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.linkBack);
            this.Controls.Add(this.textFilter);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.checkedListBoxApps);
            this.Name = "AppsFilterView";
            this.Size = new System.Drawing.Size(844, 624);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxApps;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox textFilter;
        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel linkSelect;
        private System.Windows.Forms.Label statusLabel;
    }
}
