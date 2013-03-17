namespace flintlock
{
    partial class Flintlock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flintlock));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PebbleList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Connect = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.WatchfacePic = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ReloadSettings = new System.Windows.Forms.Button();
            this.Defaults = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.FirmwarePage = new System.Windows.Forms.TabPage();
            this.FirmwareContainer = new System.Windows.Forms.SplitContainer();
            this.MainFWBox = new System.Windows.Forms.GroupBox();
            this.FWMainMetadataVersion = new System.Windows.Forms.Label();
            this.tagFWMainMetadataVersion = new System.Windows.Forms.Label();
            this.FWMainHWPlatform = new System.Windows.Forms.Label();
            this.tagFWMainHWPlatform = new System.Windows.Forms.Label();
            this.FWMainTimestamp = new System.Windows.Forms.Label();
            this.tagFWMainTimestamp = new System.Windows.Forms.Label();
            this.FWMainVersion = new System.Windows.Forms.Label();
            this.tagFWMainVersion = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FWRecovMetadataVersion = new System.Windows.Forms.Label();
            this.tagFWRecovMetadataVersion = new System.Windows.Forms.Label();
            this.FWRecovHWPlatform = new System.Windows.Forms.Label();
            this.tagFWRecovHWPlatform = new System.Windows.Forms.Label();
            this.FWRecovTimestamp = new System.Windows.Forms.Label();
            this.tagFWRecovTimestamp = new System.Windows.Forms.Label();
            this.FWRecovVersion = new System.Windows.Forms.Label();
            this.tagFWRecovVersion = new System.Windows.Forms.Label();
            this.notificationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pebbleNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MinToTray = new System.Windows.Forms.CheckBox();
            this.Autoconnect = new System.Windows.Forms.CheckBox();
            this.ShowInTray = new System.Windows.Forms.CheckBox();
            this.MediaControlchk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PPTControlchk = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchfacePic)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.FirmwarePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirmwareContainer)).BeginInit();
            this.FirmwareContainer.Panel1.SuspendLayout();
            this.FirmwareContainer.Panel2.SuspendLayout();
            this.FirmwareContainer.SuspendLayout();
            this.MainFWBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.notificationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(644, 261);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PebbleList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WatchfacePic, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PebbleList
            // 
            this.PebbleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PebbleList.Enabled = false;
            this.PebbleList.FormattingEnabled = true;
            this.PebbleList.Location = new System.Drawing.Point(3, 3);
            this.PebbleList.Name = "PebbleList";
            this.PebbleList.Size = new System.Drawing.Size(204, 24);
            this.PebbleList.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Connect, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Scan, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(204, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Connect
            // 
            this.Connect.AutoSize = true;
            this.Connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Connect.Enabled = false;
            this.Connect.Location = new System.Drawing.Point(3, 3);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(96, 28);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "&Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Scan
            // 
            this.Scan.AutoSize = true;
            this.Scan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scan.Location = new System.Drawing.Point(105, 3);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(96, 28);
            this.Scan.TabIndex = 1;
            this.Scan.Text = "&Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // WatchfacePic
            // 
            this.WatchfacePic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WatchfacePic.Image = global::flintlock.Properties.Resources.watchface_off;
            this.WatchfacePic.Location = new System.Drawing.Point(14, 73);
            this.WatchfacePic.Name = "WatchfacePic";
            this.WatchfacePic.Size = new System.Drawing.Size(182, 180);
            this.WatchfacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WatchfacePic.TabIndex = 2;
            this.WatchfacePic.TabStop = false;
            this.WatchfacePic.Click += new System.EventHandler(this.WatchfacePic_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.SettingsPage);
            this.tabControl.Controls.Add(this.FirmwarePage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(430, 261);
            this.tabControl.TabIndex = 2;
            // 
            // SettingsPage
            // 
            this.SettingsPage.Controls.Add(this.label3);
            this.SettingsPage.Controls.Add(this.MinToTray);
            this.SettingsPage.Controls.Add(this.Autoconnect);
            this.SettingsPage.Controls.Add(this.ShowInTray);
            this.SettingsPage.Controls.Add(this.MediaControlchk);
            this.SettingsPage.Controls.Add(this.label2);
            this.SettingsPage.Controls.Add(this.ReloadSettings);
            this.SettingsPage.Controls.Add(this.label1);
            this.SettingsPage.Controls.Add(this.PPTControlchk);
            this.SettingsPage.Controls.Add(this.Defaults);
            this.SettingsPage.Controls.Add(this.Apply);
            this.SettingsPage.Location = new System.Drawing.Point(4, 25);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(422, 232);
            this.SettingsPage.TabIndex = 0;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last known Pebble:";
            // 
            // ReloadSettings
            // 
            this.ReloadSettings.AutoSize = true;
            this.ReloadSettings.Location = new System.Drawing.Point(110, 183);
            this.ReloadSettings.Name = "ReloadSettings";
            this.ReloadSettings.Size = new System.Drawing.Size(75, 27);
            this.ReloadSettings.TabIndex = 3;
            this.ReloadSettings.Text = "&Reset";
            this.ReloadSettings.UseVisualStyleBackColor = true;
            this.ReloadSettings.Click += new System.EventHandler(this.ReloadSettings_Click);
            // 
            // Defaults
            // 
            this.Defaults.AutoSize = true;
            this.Defaults.Location = new System.Drawing.Point(191, 183);
            this.Defaults.Name = "Defaults";
            this.Defaults.Size = new System.Drawing.Size(75, 27);
            this.Defaults.TabIndex = 4;
            this.Defaults.Text = "&Defaults";
            this.Defaults.UseVisualStyleBackColor = true;
            this.Defaults.Click += new System.EventHandler(this.Defaults_Click);
            // 
            // Apply
            // 
            this.Apply.AutoSize = true;
            this.Apply.Location = new System.Drawing.Point(29, 183);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 27);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "&Save";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Save_Click);
            // 
            // FirmwarePage
            // 
            this.FirmwarePage.Controls.Add(this.FirmwareContainer);
            this.FirmwarePage.Location = new System.Drawing.Point(4, 25);
            this.FirmwarePage.Name = "FirmwarePage";
            this.FirmwarePage.Padding = new System.Windows.Forms.Padding(3);
            this.FirmwarePage.Size = new System.Drawing.Size(422, 232);
            this.FirmwarePage.TabIndex = 1;
            this.FirmwarePage.Text = "Firmware";
            this.FirmwarePage.UseVisualStyleBackColor = true;
            // 
            // FirmwareContainer
            // 
            this.FirmwareContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirmwareContainer.Location = new System.Drawing.Point(3, 3);
            this.FirmwareContainer.Name = "FirmwareContainer";
            // 
            // FirmwareContainer.Panel1
            // 
            this.FirmwareContainer.Panel1.Controls.Add(this.MainFWBox);
            // 
            // FirmwareContainer.Panel2
            // 
            this.FirmwareContainer.Panel2.Controls.Add(this.groupBox2);
            this.FirmwareContainer.Size = new System.Drawing.Size(416, 226);
            this.FirmwareContainer.SplitterDistance = 208;
            this.FirmwareContainer.TabIndex = 0;
            // 
            // MainFWBox
            // 
            this.MainFWBox.Controls.Add(this.FWMainMetadataVersion);
            this.MainFWBox.Controls.Add(this.tagFWMainMetadataVersion);
            this.MainFWBox.Controls.Add(this.FWMainHWPlatform);
            this.MainFWBox.Controls.Add(this.tagFWMainHWPlatform);
            this.MainFWBox.Controls.Add(this.FWMainTimestamp);
            this.MainFWBox.Controls.Add(this.tagFWMainTimestamp);
            this.MainFWBox.Controls.Add(this.FWMainVersion);
            this.MainFWBox.Controls.Add(this.tagFWMainVersion);
            this.MainFWBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFWBox.Location = new System.Drawing.Point(0, 0);
            this.MainFWBox.Name = "MainFWBox";
            this.MainFWBox.Size = new System.Drawing.Size(208, 226);
            this.MainFWBox.TabIndex = 0;
            this.MainFWBox.TabStop = false;
            this.MainFWBox.Text = "Main";
            // 
            // FWMainMetadataVersion
            // 
            this.FWMainMetadataVersion.AutoSize = true;
            this.FWMainMetadataVersion.Location = new System.Drawing.Point(20, 188);
            this.FWMainMetadataVersion.Name = "FWMainMetadataVersion";
            this.FWMainMetadataVersion.Size = new System.Drawing.Size(0, 17);
            this.FWMainMetadataVersion.TabIndex = 7;
            // 
            // tagFWMainMetadataVersion
            // 
            this.tagFWMainMetadataVersion.AutoSize = true;
            this.tagFWMainMetadataVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWMainMetadataVersion.Location = new System.Drawing.Point(6, 171);
            this.tagFWMainMetadataVersion.Name = "tagFWMainMetadataVersion";
            this.tagFWMainMetadataVersion.Size = new System.Drawing.Size(133, 17);
            this.tagFWMainMetadataVersion.TabIndex = 6;
            this.tagFWMainMetadataVersion.Text = "Metadata version";
            // 
            // FWMainHWPlatform
            // 
            this.FWMainHWPlatform.AutoSize = true;
            this.FWMainHWPlatform.Location = new System.Drawing.Point(20, 137);
            this.FWMainHWPlatform.Name = "FWMainHWPlatform";
            this.FWMainHWPlatform.Size = new System.Drawing.Size(0, 17);
            this.FWMainHWPlatform.TabIndex = 5;
            // 
            // tagFWMainHWPlatform
            // 
            this.tagFWMainHWPlatform.AutoSize = true;
            this.tagFWMainHWPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWMainHWPlatform.Location = new System.Drawing.Point(6, 120);
            this.tagFWMainHWPlatform.Name = "tagFWMainHWPlatform";
            this.tagFWMainHWPlatform.Size = new System.Drawing.Size(141, 17);
            this.tagFWMainHWPlatform.TabIndex = 4;
            this.tagFWMainHWPlatform.Text = "Hardware platform";
            // 
            // FWMainTimestamp
            // 
            this.FWMainTimestamp.AutoSize = true;
            this.FWMainTimestamp.Location = new System.Drawing.Point(20, 86);
            this.FWMainTimestamp.Name = "FWMainTimestamp";
            this.FWMainTimestamp.Size = new System.Drawing.Size(0, 17);
            this.FWMainTimestamp.TabIndex = 3;
            // 
            // tagFWMainTimestamp
            // 
            this.tagFWMainTimestamp.AutoSize = true;
            this.tagFWMainTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWMainTimestamp.Location = new System.Drawing.Point(6, 69);
            this.tagFWMainTimestamp.Name = "tagFWMainTimestamp";
            this.tagFWMainTimestamp.Size = new System.Drawing.Size(86, 17);
            this.tagFWMainTimestamp.TabIndex = 2;
            this.tagFWMainTimestamp.Text = "Timestamp";
            // 
            // FWMainVersion
            // 
            this.FWMainVersion.AutoSize = true;
            this.FWMainVersion.Location = new System.Drawing.Point(20, 35);
            this.FWMainVersion.Name = "FWMainVersion";
            this.FWMainVersion.Size = new System.Drawing.Size(0, 17);
            this.FWMainVersion.TabIndex = 1;
            // 
            // tagFWMainVersion
            // 
            this.tagFWMainVersion.AutoSize = true;
            this.tagFWMainVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWMainVersion.Location = new System.Drawing.Point(6, 18);
            this.tagFWMainVersion.Name = "tagFWMainVersion";
            this.tagFWMainVersion.Size = new System.Drawing.Size(63, 17);
            this.tagFWMainVersion.TabIndex = 0;
            this.tagFWMainVersion.Text = "Version";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FWRecovMetadataVersion);
            this.groupBox2.Controls.Add(this.tagFWRecovMetadataVersion);
            this.groupBox2.Controls.Add(this.FWRecovHWPlatform);
            this.groupBox2.Controls.Add(this.tagFWRecovHWPlatform);
            this.groupBox2.Controls.Add(this.FWRecovTimestamp);
            this.groupBox2.Controls.Add(this.tagFWRecovTimestamp);
            this.groupBox2.Controls.Add(this.FWRecovVersion);
            this.groupBox2.Controls.Add(this.tagFWRecovVersion);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 226);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recovery";
            // 
            // FWRecovMetadataVersion
            // 
            this.FWRecovMetadataVersion.AutoSize = true;
            this.FWRecovMetadataVersion.Location = new System.Drawing.Point(20, 188);
            this.FWRecovMetadataVersion.Name = "FWRecovMetadataVersion";
            this.FWRecovMetadataVersion.Size = new System.Drawing.Size(0, 17);
            this.FWRecovMetadataVersion.TabIndex = 15;
            // 
            // tagFWRecovMetadataVersion
            // 
            this.tagFWRecovMetadataVersion.AutoSize = true;
            this.tagFWRecovMetadataVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWRecovMetadataVersion.Location = new System.Drawing.Point(6, 171);
            this.tagFWRecovMetadataVersion.Name = "tagFWRecovMetadataVersion";
            this.tagFWRecovMetadataVersion.Size = new System.Drawing.Size(133, 17);
            this.tagFWRecovMetadataVersion.TabIndex = 14;
            this.tagFWRecovMetadataVersion.Text = "Metadata version";
            // 
            // FWRecovHWPlatform
            // 
            this.FWRecovHWPlatform.AutoSize = true;
            this.FWRecovHWPlatform.Location = new System.Drawing.Point(20, 137);
            this.FWRecovHWPlatform.Name = "FWRecovHWPlatform";
            this.FWRecovHWPlatform.Size = new System.Drawing.Size(0, 17);
            this.FWRecovHWPlatform.TabIndex = 13;
            // 
            // tagFWRecovHWPlatform
            // 
            this.tagFWRecovHWPlatform.AutoSize = true;
            this.tagFWRecovHWPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWRecovHWPlatform.Location = new System.Drawing.Point(6, 120);
            this.tagFWRecovHWPlatform.Name = "tagFWRecovHWPlatform";
            this.tagFWRecovHWPlatform.Size = new System.Drawing.Size(141, 17);
            this.tagFWRecovHWPlatform.TabIndex = 12;
            this.tagFWRecovHWPlatform.Text = "Hardware platform";
            // 
            // FWRecovTimestamp
            // 
            this.FWRecovTimestamp.AutoSize = true;
            this.FWRecovTimestamp.Location = new System.Drawing.Point(20, 86);
            this.FWRecovTimestamp.Name = "FWRecovTimestamp";
            this.FWRecovTimestamp.Size = new System.Drawing.Size(0, 17);
            this.FWRecovTimestamp.TabIndex = 11;
            // 
            // tagFWRecovTimestamp
            // 
            this.tagFWRecovTimestamp.AutoSize = true;
            this.tagFWRecovTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWRecovTimestamp.Location = new System.Drawing.Point(6, 69);
            this.tagFWRecovTimestamp.Name = "tagFWRecovTimestamp";
            this.tagFWRecovTimestamp.Size = new System.Drawing.Size(86, 17);
            this.tagFWRecovTimestamp.TabIndex = 10;
            this.tagFWRecovTimestamp.Text = "Timestamp";
            // 
            // FWRecovVersion
            // 
            this.FWRecovVersion.AutoSize = true;
            this.FWRecovVersion.Location = new System.Drawing.Point(20, 35);
            this.FWRecovVersion.Name = "FWRecovVersion";
            this.FWRecovVersion.Size = new System.Drawing.Size(0, 17);
            this.FWRecovVersion.TabIndex = 9;
            // 
            // tagFWRecovVersion
            // 
            this.tagFWRecovVersion.AutoSize = true;
            this.tagFWRecovVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagFWRecovVersion.Location = new System.Drawing.Point(6, 18);
            this.tagFWRecovVersion.Name = "tagFWRecovVersion";
            this.tagFWRecovVersion.Size = new System.Drawing.Size(63, 17);
            this.tagFWRecovVersion.TabIndex = 8;
            this.tagFWRecovVersion.Text = "Version";
            // 
            // notificationMenu
            // 
            this.notificationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pebbleNameToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notificationMenu.Name = "notificationMenu";
            this.notificationMenu.Size = new System.Drawing.Size(227, 100);
            // 
            // pebbleNameToolStripMenuItem
            // 
            this.pebbleNameToolStripMenuItem.Enabled = false;
            this.pebbleNameToolStripMenuItem.Name = "pebbleNameToolStripMenuItem";
            this.pebbleNameToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.pebbleNameToolStripMenuItem.Text = "Pebble 0000 on COM0";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MinToTray
            // 
            this.MinToTray.AutoSize = true;
            this.MinToTray.Checked = global::flintlock.Properties.Settings.Default.MinimizeToTray;
            this.MinToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinToTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "MinimizeToTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinToTray.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::flintlock.Properties.Settings.Default, "ShowInTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinToTray.Enabled = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.MinToTray.Location = new System.Drawing.Point(29, 131);
            this.MinToTray.Name = "MinToTray";
            this.MinToTray.Size = new System.Drawing.Size(128, 21);
            this.MinToTray.TabIndex = 9;
            this.MinToTray.Text = "Minimize to tray";
            this.MinToTray.UseVisualStyleBackColor = true;
            // 
            // Autoconnect
            // 
            this.Autoconnect.AutoSize = true;
            this.Autoconnect.Checked = global::flintlock.Properties.Settings.Default.Autoconnect;
            this.Autoconnect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "Autoconnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Autoconnect.Location = new System.Drawing.Point(6, 6);
            this.Autoconnect.Name = "Autoconnect";
            this.Autoconnect.Size = new System.Drawing.Size(243, 21);
            this.Autoconnect.TabIndex = 5;
            this.Autoconnect.Text = "Autoconnect to last known Pebble";
            this.Autoconnect.UseVisualStyleBackColor = true;
            // 
            // ShowInTray
            // 
            this.ShowInTray.AutoSize = true;
            this.ShowInTray.Checked = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.ShowInTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowInTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "ShowInTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ShowInTray.Location = new System.Drawing.Point(6, 104);
            this.ShowInTray.Name = "ShowInTray";
            this.ShowInTray.Size = new System.Drawing.Size(122, 21);
            this.ShowInTray.TabIndex = 8;
            this.ShowInTray.Text = "Show tray icon";
            this.ShowInTray.UseVisualStyleBackColor = true;
            this.ShowInTray.CheckedChanged += new System.EventHandler(this.ShowInTray_CheckedChanged);
            // 
            // MediaControlchk
            // 
            this.MediaControlchk.AutoSize = true;
            this.MediaControlchk.Checked = global::flintlock.Properties.Settings.Default.MediaControl;
            this.MediaControlchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MediaControlchk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "MediaControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MediaControlchk.Location = new System.Drawing.Point(6, 77);
            this.MediaControlchk.Name = "MediaControlchk";
            this.MediaControlchk.Size = new System.Drawing.Size(177, 21);
            this.MediaControlchk.TabIndex = 1;
            this.MediaControlchk.Text = "Control media playback";
            this.MediaControlchk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::flintlock.Properties.Settings.Default, "LastKnownPebble", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(163, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = global::flintlock.Properties.Settings.Default.LastKnownPebble;
            // 
            // PPTControlchk
            // 
            this.PPTControlchk.AutoSize = true;
            this.PPTControlchk.Checked = global::flintlock.Properties.Settings.Default.PPTControl;
            this.PPTControlchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PPTControlchk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "PPTControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PPTControlchk.Location = new System.Drawing.Point(6, 50);
            this.PPTControlchk.Name = "PPTControlchk";
            this.PPTControlchk.Size = new System.Drawing.Size(411, 21);
            this.PPTControlchk.TabIndex = 0;
            this.PPTControlchk.Text = "Control PowerPoint (blocks media control when PPT is open)";
            this.PPTControlchk.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notificationMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Disconnected";
            this.notifyIcon.Visible = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::flintlock.Properties.Settings.Default, "LastKnownPebblePort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Location = new System.Drawing.Point(210, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = global::flintlock.Properties.Settings.Default.LastKnownPebblePort;
            // 
            // Flintlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 265);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Flintlock";
            this.Text = "Flintlock";
            this.Load += new System.EventHandler(this.Flintlock_Load);
            this.Resize += new System.EventHandler(this.Flintlock_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchfacePic)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.FirmwarePage.ResumeLayout(false);
            this.FirmwareContainer.Panel1.ResumeLayout(false);
            this.FirmwareContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirmwareContainer)).EndInit();
            this.FirmwareContainer.ResumeLayout(false);
            this.MainFWBox.ResumeLayout(false);
            this.MainFWBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.notificationMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox PebbleList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.PictureBox WatchfacePic;
        private System.Windows.Forms.CheckBox MediaControlchk;
        private System.Windows.Forms.CheckBox PPTControlchk;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button ReloadSettings;
        private System.Windows.Forms.CheckBox Autoconnect;
        private System.Windows.Forms.Button Defaults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notificationMenu;
        private System.Windows.Forms.ToolStripMenuItem pebbleNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox MinToTray;
        private System.Windows.Forms.CheckBox ShowInTray;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.TabPage FirmwarePage;
        private System.Windows.Forms.SplitContainer FirmwareContainer;
        private System.Windows.Forms.GroupBox MainFWBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label FWMainMetadataVersion;
        private System.Windows.Forms.Label tagFWMainMetadataVersion;
        private System.Windows.Forms.Label FWMainHWPlatform;
        private System.Windows.Forms.Label tagFWMainHWPlatform;
        private System.Windows.Forms.Label FWMainTimestamp;
        private System.Windows.Forms.Label tagFWMainTimestamp;
        private System.Windows.Forms.Label FWMainVersion;
        private System.Windows.Forms.Label tagFWMainVersion;
        private System.Windows.Forms.Label FWRecovMetadataVersion;
        private System.Windows.Forms.Label tagFWRecovMetadataVersion;
        private System.Windows.Forms.Label FWRecovHWPlatform;
        private System.Windows.Forms.Label tagFWRecovHWPlatform;
        private System.Windows.Forms.Label FWRecovTimestamp;
        private System.Windows.Forms.Label tagFWRecovTimestamp;
        private System.Windows.Forms.Label FWRecovVersion;
        private System.Windows.Forms.Label tagFWRecovVersion;
        private System.Windows.Forms.Label label3;


    }
}

