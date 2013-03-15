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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flintlock));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PebbleList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Connect = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.FWVersion = new System.Windows.Forms.Label();
            this.RecoveryVersion = new System.Windows.Forms.Label();
            this.WatchfacePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchfacePic)).BeginInit();
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WatchfacePic)).EndInit();
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


    }
}

