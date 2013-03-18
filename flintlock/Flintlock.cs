using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        BackgroundWorker listUpdateWorker;
        delegate void UIUpdater();

        Pebble pebble;

        public Flintlock()
        {
            InitializeComponent();

            listUpdateWorker = new BackgroundWorker();
            listUpdateWorker.DoWork += listUpdateWorker_DoWork;
            listUpdateWorker.RunWorkerCompleted += listUpdateWorker_RunWorkerCompleted;
        }

        /// <summary>
        /// Set the version info based on the currently connected Pebble.
        /// </summary>
        private void SetVersionInfo()
        {
            if (pebble == null)
            {
                return;
            }
            FWMainVersion.Text = pebble.Firmware.Version + ", commit " + pebble.Firmware.Commit;
            FWMainTimestamp.Text = pebble.Firmware.Timestamp.ToString();
            FWMainHWPlatform.Text = pebble.Firmware.HardwarePlatform.ToString();
            FWMainMetadataVersion.Text = pebble.Firmware.MetadataVersion.ToString();
            FWRecovVersion.Text = pebble.RecoveryFirmware.Version + ", commit " + pebble.Firmware.Commit;
            FWRecovTimestamp.Text = pebble.RecoveryFirmware.Timestamp.ToString();
            FWRecovHWPlatform.Text = pebble.RecoveryFirmware.HardwarePlatform.ToString();
            FWRecovMetadataVersion.Text = pebble.RecoveryFirmware.MetadataVersion.ToString();
        }

        /// <summary>
        /// Reset the version info after a disconnect.
        /// </summary>
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

        /// <summary>
        /// Connect to the Pebble that's currently selected in the combobox, if any.
        /// </summary>
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

        /// <summary>
        /// Reset the UI to the disconnected state.  To be called through Invoke.
        /// </summary>
        private void DisconnectUIUpdate()
        {
            Scan.Enabled = true;
            WatchfacePic.Image = Properties.Resources.watchface_off;
            Connect.Text = "&Connect";
            pebbleNameToolStripMenuItem.Text = "Disconnected";
            disconnectToolStripMenuItem.Enabled = false;
            notifyIcon.Text = "Disconnected";
            ResetVersionInfo();
            pebble = null;
        }

        /// <summary>
        /// UI update after the Pebble autodetect has finished.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listUpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Pebble autocon = null;
            var pebbles = e.Result as List<Pebble>;
            if (pebbles != null && pebbles.Count > 0)
            {
                // Found some Pebbles, let's add them to the combobox
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
                    // Autoconnect possible and desired, so let's
                    PebbleList.SelectedItem = autocon;
                    for (int i = 0; i < 5; i++)
                    {
                        try
                        {
                            // Serial comms is awesome.  Try connecting a bunch of times with delays.
                            ConnectToSelectedPebble();
                            Thread.Sleep(1500);
                            break;
                        }
                        catch (IOException)
                        {
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Background task for Pebble autodetect.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Pebble> peblist = Pebble.DetectPebbles();
            e.Result = peblist;
        }

        #region Pebble event handlers

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
            UIUpdater u = new UIUpdater(DisconnectUIUpdate);
            Invoke(u);
        }

        private void pebble_OnConnect(object sender, EventArgs e)
        {
            // Dirtyfix for when things get out of sync for reasons yet to be found
            if (pebble == null)
            {
                return;
            }
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

        #endregion

        #region UI event handlers

        private void Scan_Click(object sender, EventArgs e)
        {
            PebbleList.Items.Clear();
            PebbleList.Enabled = false;
            Connect.Enabled = false;
            Scan.Enabled = false;
            listUpdateWorker.RunWorkerAsync();
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
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

        private void ShowInTray_CheckedChanged(object sender, EventArgs e)
        {
            // Despite the ApplicationSettings binding this apparently still needs
            // manual updating.
            notifyIcon.Visible = ShowInTray.Checked;
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

        private void Flintlock_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Autoconnect
                && Properties.Settings.Default.LastKnownPebble != "0000")
            {
                listUpdateWorker.RunWorkerAsync();
            }
        }

        private void Flintlock_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pebble != null)
            {
                pebble.Disconnect();
            }
            // Not doing this leaves a tray icon that disappears on mouseover in some setups.
            notifyIcon.Visible = false;
        }

        #endregion
    }
}
