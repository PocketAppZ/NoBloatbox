namespace Bloatboxer
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelDragDrop = new System.Windows.Forms.Panel();
            this.lblFilterSupport = new System.Windows.Forms.Label();
            this.pictureWallpaper = new System.Windows.Forms.PictureBox();
            this.assetUpload = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.btnConfirmFilter = new System.Windows.Forms.Button();
            this.filterDropdown = new System.Windows.Forms.ComboBox();
            this.btnPlugins = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblSubheader = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.linkClose = new System.Windows.Forms.LinkLabel();
            this.borderBottom = new System.Windows.Forms.Label();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.panelUpload = new System.Windows.Forms.Panel();
            this.btnStore = new System.Windows.Forms.Button();
            this.assetChevronRighStore = new System.Windows.Forms.Button();
            this.assetChevronRightAppsFilter = new System.Windows.Forms.Button();
            this.btnAppsFilter = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.panelDragDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWallpaper)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDragDrop
            // 
            this.panelDragDrop.AllowDrop = true;
            this.panelDragDrop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelDragDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelDragDrop.Controls.Add(this.lblFilterSupport);
            this.panelDragDrop.Controls.Add(this.pictureWallpaper);
            this.panelDragDrop.Controls.Add(this.assetUpload);
            this.panelDragDrop.Controls.Add(this.statusLabel);
            this.panelDragDrop.Location = new System.Drawing.Point(42, 128);
            this.panelDragDrop.Name = "panelDragDrop";
            this.panelDragDrop.Size = new System.Drawing.Size(503, 213);
            this.panelDragDrop.TabIndex = 0;
            this.panelDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDragDrop_DragDrop);
            this.panelDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDragDrop_DragEnter);
            this.panelDragDrop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDragDrop_Paint);
            // 
            // lblFilterSupport
            // 
            this.lblFilterSupport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilterSupport.AutoEllipsis = true;
            this.lblFilterSupport.BackColor = System.Drawing.Color.Transparent;
            this.lblFilterSupport.Font = new System.Drawing.Font("Segoe UI Variable Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSupport.ForeColor = System.Drawing.Color.DimGray;
            this.lblFilterSupport.Location = new System.Drawing.Point(193, 129);
            this.lblFilterSupport.Name = "lblFilterSupport";
            this.lblFilterSupport.Size = new System.Drawing.Size(131, 15);
            this.lblFilterSupport.TabIndex = 311;
            this.lblFilterSupport.Text = "Supports: JSON, PS1";
            this.lblFilterSupport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureWallpaper
            // 
            this.pictureWallpaper.Location = new System.Drawing.Point(26, 63);
            this.pictureWallpaper.Name = "pictureWallpaper";
            this.pictureWallpaper.Size = new System.Drawing.Size(120, 92);
            this.pictureWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureWallpaper.TabIndex = 305;
            this.pictureWallpaper.TabStop = false;
            // 
            // assetUpload
            // 
            this.assetUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetUpload.AutoEllipsis = true;
            this.assetUpload.BackColor = System.Drawing.Color.Transparent;
            this.assetUpload.Font = new System.Drawing.Font("Segoe MDL2 Assets", 24.75F);
            this.assetUpload.ForeColor = System.Drawing.Color.Black;
            this.assetUpload.Location = new System.Drawing.Point(3, 27);
            this.assetUpload.Name = "assetUpload";
            this.assetUpload.Size = new System.Drawing.Size(497, 43);
            this.assetUpload.TabIndex = 303;
            this.assetUpload.Text = "...";
            this.assetUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoEllipsis = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Variable Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(162, 89);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(338, 30);
            this.statusLabel.TabIndex = 312;
            this.statusLabel.Text = "Drag filter and plugins here";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConfirmFilter
            // 
            this.btnConfirmFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmFilter.AutoEllipsis = true;
            this.btnConfirmFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmFilter.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmFilter.FlatAppearance.BorderSize = 0;
            this.btnConfirmFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnConfirmFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmFilter.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F);
            this.btnConfirmFilter.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmFilter.Location = new System.Drawing.Point(509, 0);
            this.btnConfirmFilter.Name = "btnConfirmFilter";
            this.btnConfirmFilter.Size = new System.Drawing.Size(35, 30);
            this.btnConfirmFilter.TabIndex = 310;
            this.btnConfirmFilter.TabStop = false;
            this.btnConfirmFilter.Tag = "";
            this.btnConfirmFilter.Text = "...";
            this.tt.SetToolTip(this.btnConfirmFilter, "Reload");
            this.btnConfirmFilter.UseVisualStyleBackColor = false;
            this.btnConfirmFilter.Click += new System.EventHandler(this.btnReloadFilter_Click);
            // 
            // filterDropdown
            // 
            this.filterDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterDropdown.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDropdown.FormattingEnabled = true;
            this.filterDropdown.Location = new System.Drawing.Point(36, 0);
            this.filterDropdown.Name = "filterDropdown";
            this.filterDropdown.Size = new System.Drawing.Size(472, 30);
            this.filterDropdown.TabIndex = 263;
            this.filterDropdown.TabStop = false;
            this.filterDropdown.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.filterDropdown_DrawItem);
            this.filterDropdown.SelectedIndexChanged += new System.EventHandler(this.filterDropdown_SelectedIndexChanged);
            // 
            // btnPlugins
            // 
            this.btnPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlugins.AutoEllipsis = true;
            this.btnPlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnPlugins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlugins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlugins.FlatAppearance.BorderSize = 0;
            this.btnPlugins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPlugins.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlugins.ForeColor = System.Drawing.Color.Black;
            this.btnPlugins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlugins.Location = new System.Drawing.Point(24, 76);
            this.btnPlugins.Name = "btnPlugins";
            this.btnPlugins.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPlugins.Size = new System.Drawing.Size(509, 60);
            this.btnPlugins.TabIndex = 500;
            this.btnPlugins.TabStop = false;
            this.btnPlugins.Text = "Open Plugins";
            this.btnPlugins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlugins.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(584, 761);
            this.panelContainer.TabIndex = 209;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelDragDrop);
            this.panelMain.Controls.Add(this.panelUpload);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(584, 761);
            this.panelMain.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panelTop.Controls.Add(this.btnMore);
            this.panelTop.Controls.Add(this.btnAbout);
            this.panelTop.Controls.Add(this.lblSubheader);
            this.panelTop.Controls.Add(this.btnConfirmFilter);
            this.panelTop.Controls.Add(this.filterDropdown);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(584, 73);
            this.panelTop.TabIndex = 2;
            // 
            // btnMore
            // 
            this.btnMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMore.AutoEllipsis = true;
            this.btnMore.BackColor = System.Drawing.Color.Transparent;
            this.btnMore.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnMore.FlatAppearance.BorderSize = 0;
            this.btnMore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnMore.ForeColor = System.Drawing.Color.Black;
            this.btnMore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMore.Location = new System.Drawing.Point(546, 0);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(35, 30);
            this.btnMore.TabIndex = 508;
            this.btnMore.TabStop = false;
            this.btnMore.Tag = "";
            this.btnMore.Text = "...";
            this.tt.SetToolTip(this.btnMore, "Select from computer");
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.Window;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(37, 30);
            this.btnAbout.TabIndex = 507;
            this.btnAbout.TabStop = false;
            this.btnAbout.Text = "...";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt.SetToolTip(this.btnAbout, "App-Info");
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // lblSubheader
            // 
            this.lblSubheader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(206)))));
            this.lblSubheader.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSubheader.ForeColor = System.Drawing.Color.Black;
            this.lblSubheader.Location = new System.Drawing.Point(0, 30);
            this.lblSubheader.Name = "lblSubheader";
            this.lblSubheader.Size = new System.Drawing.Size(584, 40);
            this.lblSubheader.TabIndex = 305;
            this.lblSubheader.Text = "Upload your bloatware and plugin filter by dropping them below or selecting them " +
    "here";
            this.lblSubheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelBottom.Controls.Add(this.linkClose);
            this.panelBottom.Controls.Add(this.borderBottom);
            this.panelBottom.Controls.Add(this.linkGitHub);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 675);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(584, 86);
            this.panelBottom.TabIndex = 3;
            // 
            // linkClose
            // 
            this.linkClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkClose.AutoEllipsis = true;
            this.linkClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(92)))), ((int)(((byte)(219)))));
            this.linkClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkClose.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.25F, System.Drawing.FontStyle.Bold);
            this.linkClose.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkClose.LinkColor = System.Drawing.Color.White;
            this.linkClose.Location = new System.Drawing.Point(247, 29);
            this.linkClose.Name = "linkClose";
            this.linkClose.Size = new System.Drawing.Size(101, 21);
            this.linkClose.TabIndex = 307;
            this.linkClose.TabStop = true;
            this.linkClose.Text = "Close";
            this.linkClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderBottom
            // 
            this.borderBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.borderBottom.Location = new System.Drawing.Point(0, 0);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(584, 2);
            this.borderBottom.TabIndex = 257;
            // 
            // linkGitHub
            // 
            this.linkGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkGitHub.AutoEllipsis = true;
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 8.5F);
            this.linkGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkGitHub.LinkColor = System.Drawing.Color.Magenta;
            this.linkGitHub.Location = new System.Drawing.Point(9, 61);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(44, 16);
            this.linkGitHub.TabIndex = 306;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "GitHub";
            // 
            // panelUpload
            // 
            this.panelUpload.AllowDrop = true;
            this.panelUpload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelUpload.BackColor = System.Drawing.Color.Transparent;
            this.panelUpload.Controls.Add(this.btnStore);
            this.panelUpload.Controls.Add(this.assetChevronRighStore);
            this.panelUpload.Controls.Add(this.assetChevronRightAppsFilter);
            this.panelUpload.Controls.Add(this.btnAppsFilter);
            this.panelUpload.Controls.Add(this.btnPlugins);
            this.panelUpload.Location = new System.Drawing.Point(12, 357);
            this.panelUpload.Name = "panelUpload";
            this.panelUpload.Size = new System.Drawing.Size(560, 163);
            this.panelUpload.TabIndex = 264;
            // 
            // btnStore
            // 
            this.btnStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStore.AutoEllipsis = true;
            this.btnStore.BackColor = System.Drawing.Color.Transparent;
            this.btnStore.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnStore.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.5F);
            this.btnStore.ForeColor = System.Drawing.Color.Black;
            this.btnStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.Location = new System.Drawing.Point(318, 91);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(137, 30);
            this.btnStore.TabIndex = 506;
            this.btnStore.TabStop = false;
            this.btnStore.Text = "Discover Plugins";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // assetChevronRighStore
            // 
            this.assetChevronRighStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetChevronRighStore.AutoEllipsis = true;
            this.assetChevronRighStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.assetChevronRighStore.Cursor = System.Windows.Forms.Cursors.Default;
            this.assetChevronRighStore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.assetChevronRighStore.FlatAppearance.BorderSize = 0;
            this.assetChevronRighStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.assetChevronRighStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetChevronRighStore.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetChevronRighStore.ForeColor = System.Drawing.Color.Black;
            this.assetChevronRighStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assetChevronRighStore.Location = new System.Drawing.Point(485, 91);
            this.assetChevronRighStore.Name = "assetChevronRighStore";
            this.assetChevronRighStore.Size = new System.Drawing.Size(35, 30);
            this.assetChevronRighStore.TabIndex = 504;
            this.assetChevronRighStore.TabStop = false;
            this.assetChevronRighStore.Tag = "";
            this.assetChevronRighStore.Text = "...";
            this.assetChevronRighStore.UseVisualStyleBackColor = false;
            // 
            // assetChevronRightAppsFilter
            // 
            this.assetChevronRightAppsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetChevronRightAppsFilter.AutoEllipsis = true;
            this.assetChevronRightAppsFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.assetChevronRightAppsFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.assetChevronRightAppsFilter.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.assetChevronRightAppsFilter.FlatAppearance.BorderSize = 0;
            this.assetChevronRightAppsFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.assetChevronRightAppsFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assetChevronRightAppsFilter.Font = new System.Drawing.Font("Segoe MDL2 Assets", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetChevronRightAppsFilter.ForeColor = System.Drawing.Color.Black;
            this.assetChevronRightAppsFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.assetChevronRightAppsFilter.Location = new System.Drawing.Point(485, 36);
            this.assetChevronRightAppsFilter.Name = "assetChevronRightAppsFilter";
            this.assetChevronRightAppsFilter.Size = new System.Drawing.Size(35, 30);
            this.assetChevronRightAppsFilter.TabIndex = 503;
            this.assetChevronRightAppsFilter.TabStop = false;
            this.assetChevronRightAppsFilter.Tag = "";
            this.assetChevronRightAppsFilter.Text = "...";
            this.assetChevronRightAppsFilter.UseVisualStyleBackColor = false;
            // 
            // btnAppsFilter
            // 
            this.btnAppsFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppsFilter.AutoEllipsis = true;
            this.btnAppsFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.btnAppsFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppsFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppsFilter.FlatAppearance.BorderSize = 0;
            this.btnAppsFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAppsFilter.Font = new System.Drawing.Font("Segoe UI Variable Text Semiligh", 11.25F);
            this.btnAppsFilter.ForeColor = System.Drawing.Color.Black;
            this.btnAppsFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppsFilter.Location = new System.Drawing.Point(24, 18);
            this.btnAppsFilter.Name = "btnAppsFilter";
            this.btnAppsFilter.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAppsFilter.Size = new System.Drawing.Size(509, 60);
            this.btnAppsFilter.TabIndex = 502;
            this.btnAppsFilter.TabStop = false;
            this.btnAppsFilter.Text = "Selectively Punch Bloatware";
            this.btnAppsFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppsFilter.UseVisualStyleBackColor = true;
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.panelContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = " Bloatboxer";
            this.panelDragDrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWallpaper)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelUpload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDragDrop;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label assetUpload;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label borderBottom;
        private System.Windows.Forms.Button btnPlugins;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.ComboBox filterDropdown;
        private System.Windows.Forms.Panel panelUpload;
        private System.Windows.Forms.PictureBox pictureWallpaper;
        private System.Windows.Forms.Button btnConfirmFilter;
        private System.Windows.Forms.Label lblFilterSupport;
        private System.Windows.Forms.Label lblSubheader;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button btnAppsFilter;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.Button assetChevronRighStore;
        private System.Windows.Forms.Button assetChevronRightAppsFilter;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.LinkLabel linkClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMore;
    }
}

