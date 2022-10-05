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
using System.Net.Sockets;

namespace Network_Tool
{
    public partial class Form1 : Form
    {
        Client clientConnection = new Client();
        Server serverConnection = new Server();
        public Form1()
        {
            InitializeComponent();
            textClientIP.Text = "192.168.1.120";
            textClientPort.Text = Convert.ToString(23);
            textServerPort.Text = Convert.ToString(23);
            clientConnection.DataReceived += ClientConnection_DataReceived;
            clientConnection.Connected += ClientConnection_Connected;
            clientConnection.Disconnected += ClientConnection_Disconnected;

            serverConnection.DataReceived += ServerConnection_DataReceived;
            serverConnection.Connected += ServerConnection_Connected;
            serverConnection.Disconnected += ServerConnection_Disconnected;
            serverConnection.Waiting += ServerConnection_Waiting;

        }

        private void ServerConnection_Waiting(object sender, EventArgs e)
        {
            labelServerStatus.Text = "Waiting for Connection";
        }

        private void ServerConnection_Disconnected(object sender, EventArgs e)
        {
            labelServerStatus.Text = "Disconnected";
        }

        private void ServerConnection_Connected(object sender, EventArgs e)
        {
            labelServerStatus.Text = "Connected";
        }

        private void ServerConnection_DataReceived(object sender, EventArgs e)
        {
            textServerReceived.Text = serverConnection.Data;
        }

        private void ClientConnection_Disconnected(object sender, EventArgs e)
        {
            try
            {
                labelClientStatus.Text = "Disconnected";
            }
            catch
            {

            }
        }

        private void ClientConnection_Connected(object sender, EventArgs e)
        {
            labelClientStatus.Text = "Connected";
        }

        private void ClientConnection_DataReceived(object sender, EventArgs e)
        {
            try
            {
                textClientReceived.Text = clientConnection.Data;
            }
            catch
            {

            }
        }

        private void btnClientConnect_Click(object sender, EventArgs e)
        {
            clientConnection.Connect(IPAddress.Parse(textClientIP.Text), Convert.ToInt32(textClientPort.Text));
        }

        private void btnClientDisconnect_Click(object sender, EventArgs e)
        {
            clientConnection.Disconnect();
        }

        private void btnClientSend_Click(object sender, EventArgs e)
        {
            clientConnection.Send(textClientSend.Text);
        }

        private async void btnServerStart_Click(object sender, EventArgs e)
        {
            await serverConnection.Start(Convert.ToInt32(textServerPort.Text));
        }

        private void btnServerStop_Click(object sender, EventArgs e)
        {
            serverConnection.Stop();
        }

        private void btnServerSend_Click(object sender, EventArgs e)
        {
            serverConnection.Send(textServerSend.Text);
        }
    }
}
