namespace Bloatboxer
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.flowLayoutPanelPlugins = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxRepoSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F);
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxSearch.Location = new System.Drawing.Point(174, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(144, 27);
            this.textBoxSearch.TabIndex = 318;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.Text = "Search";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSubmit.FlatAppearance.BorderSize = 2;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.5F);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(342, 36);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 29);
            this.btnSubmit.TabIndex = 317;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "Submit a Plugin";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // flowLayoutPanelPlugins
            // 
            this.flowLayoutPanelPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPlugins.AutoScroll = true;
            this.flowLayoutPanelPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.flowLayoutPanelPlugins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.flowLayoutPanelPlugins.Location = new System.Drawing.Point(60, 83);
            this.flowLayoutPanelPlugins.Name = "flowLayoutPanelPlugins";
            this.flowLayoutPanelPlugins.Size = new System.Drawing.Size(398, 455);
            this.flowLayoutPanelPlugins.TabIndex = 316;
            this.flowLayoutPanelPlugins.TabStop = true;
            // 
            // comboBoxRepoSelector
            // 
            this.comboBoxRepoSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxRepoSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRepoSelector.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxRepoSelector.Font = new System.Drawing.Font("Segoe UI Variable Text", 11.25F);
            this.comboBoxRepoSelector.FormattingEnabled = true;
            this.comboBoxRepoSelector.Location = new System.Drawing.Point(113, 556);
            this.comboBoxRepoSelector.Name = "comboBoxRepoSelector";
            this.comboBoxRepoSelector.Size = new System.Drawing.Size(149, 28);
            this.comboBoxRepoSelector.TabIndex = 319;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 320;
            this.label1.Text = "Source";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(515, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRepoSelector);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.flowLayoutPanelPlugins);
            this.Name = "ConnectForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPlugins;
        private System.Windows.Forms.ComboBox comboBoxRepoSelector;
        private System.Windows.Forms.Label label1;
    }
}