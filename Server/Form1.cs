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
        SimpleTcpServer server;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Start();
            text_info.Text += $"Başlatılıyor .. {Environment.NewLine}";
            text_info.Text += $"Başlatıldı";
            buton_Baslat.Enabled = false;
            buton_Gonder.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buton_Gonder.Enabled = false;
            server = new SimpleTcpServer(text_IP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                text_info.Text += $" : {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
   
            });
        }

        private void Events_ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                text_info.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                list_ClientIP.Items.Remove(e.IpPort);

            });
            
        }

        private void Events_ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                text_info.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                list_ClientIP.Items.Add(e.IpPort);
            });
            
         }


        private void buton_Gonder_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if(text_Mesaj.Text != null && list_ClientIP.SelectedItem !=null)
                {
                    server.Send(list_ClientIP.SelectedItem.ToString(), text_Mesaj.Text);
                    text_info.Text += $"Sunucu :{text_Mesaj.Text}{Environment.NewLine} ";
                    text_Mesaj.Text = string.Empty;

                }
            }
        }
    }
}
