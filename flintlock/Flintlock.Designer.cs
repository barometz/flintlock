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
            this.FWVersion = new System.Windows.Forms.Label();
            this.RecoveryVersion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Apply = new System.Windows.Forms.Button();
            this.Defaults = new System.Windows.Forms.Button();
            this.ReloadSettings = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notificationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pebbleNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowInTray = new System.Windows.Forms.CheckBox();
            this.MinToTray = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Autoconnect = new System.Windows.Forms.CheckBox();
            this.PPTControlchk = new System.Windows.Forms.CheckBox();
            this.MediaControlchk = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchfacePic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.notificationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(642, 542);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.PebbleList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WatchfacePic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FWVersion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.RecoveryVersion, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(211, 542);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PebbleList
            // 
            this.PebbleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PebbleList.Enabled = false;
            this.PebbleList.FormattingEnabled = true;
            this.PebbleList.Location = new System.Drawing.Point(3, 3);
            this.PebbleList.Name = "PebbleList";
            this.PebbleList.Size = new System.Drawing.Size(205, 24);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(205, 34);
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
            this.Scan.Size = new System.Drawing.Size(97, 28);
            this.Scan.TabIndex = 1;
            this.Scan.Text = "&Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // WatchfacePic
            // 
            this.WatchfacePic.Image = global::flintlock.Properties.Resources.watchface_off;
            this.WatchfacePic.Location = new System.Drawing.Point(3, 73);
            this.WatchfacePic.Name = "WatchfacePic";
            this.WatchfacePic.Size = new System.Drawing.Size(205, 195);
            this.WatchfacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WatchfacePic.TabIndex = 2;
            this.WatchfacePic.TabStop = false;
            this.WatchfacePic.Click += new System.EventHandler(this.WatchfacePic_Click);
            // 
            // FWVersion
            // 
            this.FWVersion.AutoSize = true;
            this.FWVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FWVersion.Location = new System.Drawing.Point(3, 271);
            this.FWVersion.Name = "FWVersion";
            this.FWVersion.Size = new System.Drawing.Size(205, 122);
            this.FWVersion.TabIndex = 3;
            this.FWVersion.Text = "Firmware\r\n";
            // 
            // RecoveryVersion
            // 
            this.RecoveryVersion.AutoSize = true;
            this.RecoveryVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecoveryVersion.Location = new System.Drawing.Point(3, 393);
            this.RecoveryVersion.Name = "RecoveryVersion";
            this.RecoveryVersion.Size = new System.Drawing.Size(205, 149);
            this.RecoveryVersion.TabIndex = 4;
            this.RecoveryVersion.Text = "Recovery";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinToTray);
            this.groupBox1.Controls.Add(this.ShowInTray);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Autoconnect);
            this.groupBox1.Controls.Add(this.Apply);
            this.groupBox1.Controls.Add(this.Defaults);
            this.groupBox1.Controls.Add(this.PPTControlchk);
            this.groupBox1.Controls.Add(this.ReloadSettings);
            this.groupBox1.Controls.Add(this.MediaControlchk);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 216);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last known Pebble:";
            // 
            // Apply
            // 
            this.Apply.AutoSize = true;
            this.Apply.Location = new System.Drawing.Point(29, 173);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 27);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "&Save";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Save_Click);
            // 
            // Defaults
            // 
            this.Defaults.AutoSize = true;
            this.Defaults.Location = new System.Drawing.Point(191, 173);
            this.Defaults.Name = "Defaults";
            this.Defaults.Size = new System.Drawing.Size(75, 27);
            this.Defaults.TabIndex = 4;
            this.Defaults.Text = "&Defaults";
            this.Defaults.UseVisualStyleBackColor = true;
            this.Defaults.Click += new System.EventHandler(this.Defaults_Click);
            // 
            // ReloadSettings
            // 
            this.ReloadSettings.AutoSize = true;
            this.ReloadSettings.Location = new System.Drawing.Point(110, 173);
            this.ReloadSettings.Name = "ReloadSettings";
            this.ReloadSettings.Size = new System.Drawing.Size(75, 27);
            this.ReloadSettings.TabIndex = 3;
            this.ReloadSettings.Text = "&Reset";
            this.ReloadSettings.UseVisualStyleBackColor = true;
            this.ReloadSettings.Click += new System.EventHandler(this.ReloadSettings_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notificationMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Disconnected";
            this.notifyIcon.Visible = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
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
            // ShowInTray
            // 
            this.ShowInTray.AutoSize = true;
            this.ShowInTray.Checked = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.ShowInTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowInTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "ShowInTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ShowInTray.Location = new System.Drawing.Point(6, 119);
            this.ShowInTray.Name = "ShowInTray";
            this.ShowInTray.Size = new System.Drawing.Size(122, 21);
            this.ShowInTray.TabIndex = 8;
            this.ShowInTray.Text = "Show tray icon";
            this.ShowInTray.UseVisualStyleBackColor = true;
            this.ShowInTray.CheckedChanged += new System.EventHandler(this.ShowInTray_CheckedChanged);
            // 
            // MinToTray
            // 
            this.MinToTray.AutoSize = true;
            this.MinToTray.Checked = global::flintlock.Properties.Settings.Default.MinimizeToTray;
            this.MinToTray.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MinToTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "MinimizeToTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinToTray.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::flintlock.Properties.Settings.Default, "ShowInTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MinToTray.Enabled = global::flintlock.Properties.Settings.Default.ShowInTray;
            this.MinToTray.Location = new System.Drawing.Point(29, 146);
            this.MinToTray.Name = "MinToTray";
            this.MinToTray.Size = new System.Drawing.Size(128, 21);
            this.MinToTray.TabIndex = 9;
            this.MinToTray.Text = "Minimize to tray";
            this.MinToTray.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::flintlock.Properties.Settings.Default, "LastKnownPebble", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Location = new System.Drawing.Point(163, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = global::flintlock.Properties.Settings.Default.LastKnownPebble;
            // 
            // Autoconnect
            // 
            this.Autoconnect.AutoSize = true;
            this.Autoconnect.Checked = global::flintlock.Properties.Settings.Default.Autoconnect;
            this.Autoconnect.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "Autoconnect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Autoconnect.Location = new System.Drawing.Point(6, 21);
            this.Autoconnect.Name = "Autoconnect";
            this.Autoconnect.Size = new System.Drawing.Size(243, 21);
            this.Autoconnect.TabIndex = 5;
            this.Autoconnect.Text = "Autoconnect to last known Pebble";
            this.Autoconnect.UseVisualStyleBackColor = true;
            // 
            // PPTControlchk
            // 
            this.PPTControlchk.AutoSize = true;
            this.PPTControlchk.Checked = global::flintlock.Properties.Settings.Default.PPTControl;
            this.PPTControlchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PPTControlchk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "PPTControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PPTControlchk.Location = new System.Drawing.Point(6, 65);
            this.PPTControlchk.Name = "PPTControlchk";
            this.PPTControlchk.Size = new System.Drawing.Size(411, 21);
            this.PPTControlchk.TabIndex = 0;
            this.PPTControlchk.Text = "Control PowerPoint (blocks media control when PPT is open)";
            this.PPTControlchk.UseVisualStyleBackColor = true;
            // 
            // MediaControlchk
            // 
            this.MediaControlchk.AutoSize = true;
            this.MediaControlchk.Checked = global::flintlock.Properties.Settings.Default.MediaControl;
            this.MediaControlchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MediaControlchk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::flintlock.Properties.Settings.Default, "MediaControl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.MediaControlchk.Location = new System.Drawing.Point(6, 92);
            this.MediaControlchk.Name = "MediaControlchk";
            this.MediaControlchk.Size = new System.Drawing.Size(177, 21);
            this.MediaControlchk.TabIndex = 1;
            this.MediaControlchk.Text = "Control media playback";
            this.MediaControlchk.UseVisualStyleBackColor = true;
            // 
            // Flintlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(642, 542);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Flintlock";
            this.Text = "Flintlock";
            this.Resize += new System.EventHandler(this.Flintlock_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchfacePic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label FWVersion;
        private System.Windows.Forms.Label RecoveryVersion;
        private System.Windows.Forms.CheckBox MediaControlchk;
        private System.Windows.Forms.CheckBox PPTControlchk;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button ReloadSettings;
        private System.Windows.Forms.GroupBox groupBox1;
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


    }
}

