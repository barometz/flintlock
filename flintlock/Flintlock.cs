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
            Process[] ppts = Process.GetProcessesByName("POWERPNT");
            if (ppts.Count() > 0)
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
        }

        void pebble_OnDisconnect(object sender, EventArgs e)
        {
            WatchfacePic.Image = Properties.Resources.watchface_off;
            Connect.Text = "&Connect";
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

    }
}
