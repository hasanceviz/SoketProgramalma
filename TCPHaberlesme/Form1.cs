using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPHaberlesme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buton_Baglan_Click(object sender, EventArgs e)
        {
            
            try
            {
                client.Connect();
                buton_Gonder.Enabled = true;
                buton_Baglan.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buton_Gonder_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if (text_Mesaj.Text != "") 
                {
                    client.Send(text_Mesaj.Text);
                    text_İnfo.Text += $"Ben : {text_Mesaj.Text}{Environment.NewLine}";
                    text_Mesaj.Text = string.Empty;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(text_IP.Text);
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DaraReceived;
            client.Events.Disconnected += Events_Disconnected;
            buton_Gonder.Enabled = false;
        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                text_İnfo.Text += $"Sunucuya Bağlanılamadı.{Environment.NewLine}";

            });
        }

        private void Events_DaraReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                text_İnfo.Text += $"Sunucu : {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";

            });
            
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                text_İnfo.Text += $"Sunucuya Bağlanıldı.{Environment.NewLine}";

            });
        }

        private void list_clientIP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
