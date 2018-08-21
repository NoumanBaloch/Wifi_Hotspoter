using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WIFI_HotSpoter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd", String.Format("/c {0} & {1} & {2}", "netsh wlna set hostednetwork mode=allow ssid = " + txtWifi.Text + " key = " + txtPassword.Text, "netsh wlan start hostednetwork", "exit"));
                MessageBox.Show("WIFI_HotSpoter Created Successfuly");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c netsh wlan stop hostednetwork");
            MessageBox.Show("WIFI_HotSpoter Stoped Successfuly");
        }

        private void lnkPasswordShowHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = true;
        }

       

        
    }
}
