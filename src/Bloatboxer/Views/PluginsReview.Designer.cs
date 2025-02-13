namespace Bloatboxer.Views
{
    partial class PluginsReview
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewSc = new System.Windows.Forms.Button();
            this.textSummary = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
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
            this.lblHeader.Size = new System.Drawing.Size(779, 39);
            this.lblHeader.TabIndex = 258;
            this.lblHeader.Text = "Review your selections";
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
            this.btnBack.TabIndex = 255;
            this.btnBack.TabStop = false;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewSc
            // 
            this.btnViewSc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewSc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnViewSc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewSc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewSc.Font = new System.Drawing.Font("Segoe UI Variable Text", 8F);
            this.btnViewSc.ForeColor = System.Drawing.Color.White;
            this.btnViewSc.Location = new System.Drawing.Point(675, 493);
            this.btnViewSc.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewSc.Name = "btnViewSc";
            this.btnViewSc.Size = new System.Drawing.Size(115, 27);
            this.btnViewSc.TabIndex = 259;
            this.btnViewSc.TabStop = false;
            this.btnViewSc.Text = "View script";
            this.btnViewSc.UseVisualStyleBackColor = false;
            this.btnViewSc.Click += new System.EventHandler(this.btnViewSc_Click);
            // 
            // textSummary
            // 
            this.textSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSummary.Font = new System.Drawing.Font("Segoe UI Variable Small", 10.5F);
            this.textSummary.ForeColor = System.Drawing.Color.Black;
            this.textSummary.Location = new System.Drawing.Point(40, 80);
            this.textSummary.Margin = new System.Windows.Forms.Padding(4);
            this.textSummary.Multiline = true;
            this.textSummary.Name = "textSummary";
            this.textSummary.ReadOnly = true;
            this.textSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSummary.Size = new System.Drawing.Size(763, 405);
            this.textSummary.TabIndex = 257;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.AutoEllipsis = true;
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRun.FlatAppearance.BorderSize = 2;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(688, 559);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(115, 31);
            this.btnRun.TabIndex = 256;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // PluginsReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewSc);
            this.Controls.Add(this.textSummary);
            this.Controls.Add(this.btnRun);
            this.Name = "PluginsReview";
            this.Size = new System.Drawing.Size(844, 624);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewSc;
        private System.Windows.Forms.TextBox textSummary;
        private System.Windows.Forms.Button btnRun;
    }
}
