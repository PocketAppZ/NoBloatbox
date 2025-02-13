namespace Bloatboxer
{
    partial class LoggerForm
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
            this.border = new System.Windows.Forms.Label();
            this.btnAppDev = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.border.ForeColor = System.Drawing.Color.Transparent;
            this.border.Location = new System.Drawing.Point(-7, 40);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(441, 1);
            this.border.TabIndex = 270;
            // 
            // btnAppDev
            // 
            this.btnAppDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppDev.AutoSize = true;
            this.btnAppDev.BackColor = System.Drawing.Color.Transparent;
            this.btnAppDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppDev.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAppDev.FlatAppearance.BorderSize = 0;
            this.btnAppDev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAppDev.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAppDev.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 9F);
            this.btnAppDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnAppDev.Location = new System.Drawing.Point(239, 6);
            this.btnAppDev.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppDev.Name = "btnAppDev";
            this.btnAppDev.Size = new System.Drawing.Size(174, 30);
            this.btnAppDev.TabIndex = 269;
            this.btnAppDev.TabStop = false;
            this.btnAppDev.Text = "Send feedback in GitHub";
            this.btnAppDev.UseVisualStyleBackColor = false;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(12, 8);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(155, 24);
            this.lblHeader.TabIndex = 268;
            this.lblHeader.Text = "Notifications";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.AutoWordSelection = true;
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.25F, System.Drawing.FontStyle.Bold);
            this.rtbLog.ForeColor = System.Drawing.Color.Black;
            this.rtbLog.Location = new System.Drawing.Point(18, 51);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(396, 510);
            this.rtbLog.TabIndex = 266;
            this.rtbLog.Text = "";
            this.rtbLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbLog_LinkClicked);
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 573);
            this.Controls.Add(this.border);
            this.Controls.Add(this.btnAppDev);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.rtbLog);
            this.Name = "LoggerForm";
            this.ShowIcon = false;
            this.Text = "Toasts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label border;
        private System.Windows.Forms.Button btnAppDev;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}