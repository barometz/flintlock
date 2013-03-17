using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using flint;


namespace flintlock
{
    public partial class Flintlock : Form
    {
        delegate void Updater(List<Pebble> pebbles);
        Pebble pebble;

        public Flintlock()
        {
            InitializeComponent();
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            PebbleList.Items.Clear();
            PebbleList.Enabled = false;
            Connect.Enabled = false;
            Scan.Enabled = false;
            Thread peblookup = new Thread(new ThreadStart(ScanForPebbles));
            peblookup.Start();
        }

        private void ScanForPebbles()
        {
            
            List<Pebble> peblist = Pebble.DetectPebbles();
            Updater updater = new Updater(UpdatePebbleList);
            if (PebbleList.InvokeRequired || Connect.InvokeRequired || Scan.InvokeRequired)
            {
                Invoke(updater, peblist);
            }
            else
            {
                UpdatePebbleList(peblist);
            }
        }

        private void UpdatePebbleList(List<Pebble> pebbles)
        {
            if (pebbles.Count > 0)
            {
                foreach (Pebble peb in pebbles)
                {
                    PebbleList.Items.Add(peb);
                }
                PebbleList.Enabled = true;
                PebbleList.SelectedIndex = 0;
                Connect.Enabled = true;
                Scan.Enabled = true;
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (pebble != null)
            {
                pebble.Disconnect();
                pebble = null;
            }
            else
            {
                pebble = PebbleList.SelectedItem as Pebble;
                if (pebble != null)
                {
                    pebble.OnConnect += pebble_OnConnect;
                    pebble.OnDisconnect += pebble_OnDisconnect;
                    pebble.MediaControlReceived += pebble_MediaControlReceived;
                    try
                    {
                        pebble.Connect();
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Fail.");
                    }
                }
            }
        }

        void pebble_MediaControlReceived(object sender, MediaControlReceivedEventArgs e)
        {
            if (Properties.Settings.Default.PPTControl
                && Process.GetProcessesByName("POWERPNT").Count() > 0)
            {
                switch (e.Command)
                {
                    case Pebble.MediaControls.Forward:
                        SendKeys.SendWait(" ");
                        break;
                    case Pebble.MediaControls.Previous:
                        SendKeys.SendWait("{LEFT}");
                        break;
                }
            }
            else if (Properties.Settings.Default.MediaControl)
            {
                switch (e.Command)
                {
                    case Pebble.MediaControls.PlayPause:
                        MediaControl.PlayPause();
                        break;
                    case Pebble.MediaControls.Forward:
                        MediaControl.Next();
                        break;
                    case Pebble.MediaControls.Previous:
                        MediaControl.Prev();
                        break;
                }
            }
        }

        void pebble_OnDisconnect(object sender, EventArgs e)
        {
            WatchfacePic.Image = Properties.Resources.watchface_off;
            Connect.Text = "&Connect";
            pebbleNameToolStripMenuItem.Text = "Disconnected";
            disconnectToolStripMenuItem.Enabled = false;
            notifyIcon.Text = "Disconnected";
        }

        void pebble_OnConnect(object sender, EventArgs e)
        {
            WatchfacePic.Image = Properties.Resources.watchface;
            Connect.Text = "Dis&connect";
            PebbleList.Enabled = false;
            try
            {
                pebble.GetVersion();
                FWVersion.Text = "Firmware: \n" + pebble.Firmware.ToString();
                RecoveryVersion.Text = "Recovery: \n" + pebble.RecoveryFirmware.ToString();
                Properties.Settings.Default.LastKnownPebble = pebble.PebbleID;
                // Don't really like saving *all* settings here
                Properties.Settings.Default.Save();
                pebbleNameToolStripMenuItem.Text = pebble.ToString();
                disconnectToolStripMenuItem.Enabled = true;
                notifyIcon.Text = "Connected (" + pebble.PebbleID + ")";
            }
            // Some stuff that can go wrong while connecting...
            catch (TimeoutException err)
            {
                pebble.Disconnect();
                var result = MessageBox.Show(err.Message, "Connection timeout", 
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == System.Windows.Forms.DialogResult.Retry)
                {
                    // This doesn't actually work yet, it seems.  Possibly an issue in flint.
                    pebble.Connect();
                }
            }
            catch (InvalidOperationException err)
            {
                pebble.Disconnect();
                MessageBox.Show(err.Message + "\nTry scanning again.", "Connection failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WatchfacePic_Click(object sender, EventArgs e)
        {
            if (pebble != null && pebble.Alive)
            {
                pebble.Ping(async: true);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void ReloadSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void Defaults_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pebble.Disconnect();
        }

        private void Flintlock_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized
                && Properties.Settings.Default.ShowInTray
                && Properties.Settings.Default.MinimizeToTray)
            {
                this.Hide();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ShowInTray_CheckedChanged(object sender, EventArgs e)
        {
            notifyIcon.Visible = ShowInTray.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pebble != null)
            {
                pebble.Disconnect();
            }
            this.Close();
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

    }
}
