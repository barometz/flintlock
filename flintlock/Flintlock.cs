using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            Pebble autocon = null;
            if (pebbles.Count > 0)
            {
                foreach (Pebble peb in pebbles)
                {
                    PebbleList.Items.Add(peb);
                    if (peb.PebbleID == Properties.Settings.Default.LastKnownPebble
                        && peb.Port == Properties.Settings.Default.LastKnownPebblePort)
                    {
                        autocon = peb;
                    }
                }
                PebbleList.Enabled = true;
                PebbleList.SelectedIndex = 0;
                Connect.Enabled = true;
                Scan.Enabled = true;

                if (autocon != null
                    && Properties.Settings.Default.Autoconnect)
                {
                    PebbleList.SelectedItem = autocon;
                    for (int i = 0; i < 5; i++)
                    {
                        try
                        {
                            Thread.Sleep(1500);
                            ConnectToSelectedPebble();
                            break;
                        }
                        catch (IOException)
                        {
                        }
                    }
                }

            }
        }

        private void SetVersionInfo()
        {
            FWMainVersion.Text = pebble.Firmware.Version + ", commit " + pebble.Firmware.Commit;
            FWMainTimestamp.Text = pebble.Firmware.Timestamp.ToString();
            FWMainHWPlatform.Text = pebble.Firmware.HardwarePlatform.ToString();
            FWMainMetadataVersion.Text = pebble.Firmware.MetadataVersion.ToString();
            FWRecovVersion.Text = pebble.RecoveryFirmware.Version + ", commit " + pebble.Firmware.Commit;
            FWRecovTimestamp.Text = pebble.RecoveryFirmware.Timestamp.ToString();
            FWRecovHWPlatform.Text = pebble.RecoveryFirmware.HardwarePlatform.ToString();
            FWRecovMetadataVersion.Text = pebble.RecoveryFirmware.MetadataVersion.ToString();
        }

        private void ResetVersionInfo()
        {
            FWMainVersion.ResetText();
            FWMainTimestamp.ResetText();
            FWMainHWPlatform.ResetText();
            FWMainMetadataVersion.ResetText();
            FWRecovVersion.ResetText();
            FWRecovTimestamp.ResetText();
            FWRecovHWPlatform.ResetText();
            FWRecovMetadataVersion.ResetText();
        }

        private void ConnectToSelectedPebble()
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
                catch (IOException e)
                {
                    MessageBox.Show("Failed to connect: " + e.Message);
                    pebble = null;
                }
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
                ConnectToSelectedPebble();
            }
        }

        private void pebble_MediaControlReceived(object sender, MediaControlReceivedEventArgs e)
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

        private void pebble_OnDisconnect(object sender, EventArgs e)
        {
            Scan.Enabled = true;
            WatchfacePic.Image = Properties.Resources.watchface_off;
            Connect.Text = "&Connect";
            pebbleNameToolStripMenuItem.Text = "Disconnected";
            disconnectToolStripMenuItem.Enabled = false;
            notifyIcon.Text = "Disconnected";
            ResetVersionInfo();
        }

        private void pebble_OnConnect(object sender, EventArgs e)
        {
            WatchfacePic.Image = Properties.Resources.watchface;
            Connect.Text = "Dis&connect";
            PebbleList.Enabled = false;
            try
            {
                pebble.GetVersion();
                Scan.Enabled = false;
                SetVersionInfo();
                Properties.Settings.Default.LastKnownPebble = pebble.PebbleID;
                Properties.Settings.Default.LastKnownPebblePort = pebble.Port;
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
                MessageBox.Show(err.Message, "Connection timeout", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                pebble = null;
            }
            catch (InvalidOperationException err)
            {
                pebble.Disconnect();
                MessageBox.Show(err.Message + "\nTry scanning again.", "Connection failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                pebble = null;
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

        private void Flintlock_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Autoconnect
                && Properties.Settings.Default.LastKnownPebble != "0000")
            {
                ScanForPebbles();
            }
        }

    }
}
