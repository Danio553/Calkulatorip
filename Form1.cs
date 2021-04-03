using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;



namespace Calkulatorip
{
    public partial class Form1 : Form
    {
        static Regex rgx = new Regex(@"(^|\.)0+(?!\.|$)", RegexOptions.Compiled);
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateIP(object sender, EventArgs e) {
            String ipString = IPTextBox.Text;
            ipString = rgx.Replace(ipString, ".");

            IPAddress ipAddress = IPAddress.Parse(ipString);
            IPAddress maskAddress = IPAddress.Parse(MaskaTextBox.Text);
            byte[] ip = ipAddress.GetAddressBytes();
            byte[] mask = maskAddress.GetAddressBytes();

            IPNetwork network = IPNetwork.Parse(ipAddress.ToString(), maskAddress.ToString());
            IPTextBox.Text = network.Value;
            MaskaTextBox.Text = network.Netmask.ToString();
            networkAddressTextBox.Text = network.Network.ToString();
            BroadcastTextBox.Text = network.Broadcast.ToString();
            FirstusefulTextBox.Text = network.FirstUsable.ToString();
            LastusefulTextBox.Text = network.LastUsable.ToString();
            

        }
    }
}
