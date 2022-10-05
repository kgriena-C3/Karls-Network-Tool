using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Network_Tool
{
    class Client
    {
        public event EventHandler DataReceived;
        public event EventHandler Disconnected;
        public event EventHandler Connected;
        public string Data = "";
        private TcpClient tcpClient = new TcpClient();
        public async void Connect(IPAddress clientIP,int clientPort)
        {
            Disconnect();
            TcpClient new_tcpClient = new TcpClient();
            tcpClient = new_tcpClient;
            try
            {
                await tcpClient.ConnectAsync(clientIP, clientPort);
                Connected(this, new EventArgs());
                Receive(tcpClient);
            }
            catch
            {
            }
        }

        public void Disconnect()
        {
            tcpClient.Close();
            Disconnected(this, new EventArgs());
            Data = "";
            DataChange();
        }
        
        public void Send(string Command)
        {
            try
            {
                byte[] ba = new byte[500];
                NetworkStream Tx = tcpClient.GetStream();
                while (Command.Contains("\x5cx"))
                {
                    string Command2 = Command.Substring(0, Command.IndexOf("\x5cx"));
                    ba = Encoding.UTF8.GetBytes(Command2);
                    Tx.Write(ba, 0, ba.Length);
                    string Command3 = Command.Substring(Command.IndexOf("\x5cx") + 2, 1);
                    string Command4 = Command.Substring(Command.IndexOf("\x5cx") + 3, 1);
                    int Command5 = 0;
                    if (Command4 == "a")
                    {
                        Command5 = Convert.ToInt16(Command3) * 16 + 10;
                    }
                    else if (Command4 == "b")
                    {
                        Command5 = Convert.ToInt16(Command3) * 16 + 11;
                    }
                    else if (Command4 == "c")
                    {
                        Command5 = Convert.ToInt16(Command3) * 16 + 12;
                    }
                    else if (Command4 == "d")
                    {
                        Command5 = Convert.ToInt16(Command3) * 16 + 13;
                    }
                    else if (Command4 == "e")
                    {
                        Command5 = Convert.ToInt16(Command3) * 16 + 14;
                    }
                    else if (Command4 == "f")
                    {
                        Command5 = Convert.ToInt16(Command3) * 16 + 15;
                    }
                    ba = BitConverter.GetBytes(Command5);
                    Tx.Write(ba, 0, 1);
                    string Command6 = Command.Substring(Command.IndexOf("\x5cx") + 4);
                    Command = Command6;
                }
                ba = Encoding.UTF8.GetBytes(Command);
                Tx.Write(ba, 0, ba.Length);
            }
            catch
            {

            }
        }

        private async void Receive(TcpClient tcpClient)
        {
            while (tcpClient.Connected)
            {
                try
                {
                    NetworkStream Rx = tcpClient.GetStream();
                    if(Rx!=null)
                    {
                        byte[] bb = new byte[1000000];
                        int k = await Rx.ReadAsync (bb, 0, 1000000);
                        for (int i = 0; i < k; i++)
                        {
                            Data = Data + Convert.ToChar(bb[i]);
                        }
                    }
                    DataChange();
                }
                catch
                {

                }
            }
            Disconnected(this, new EventArgs());
        }

        private void DataChange()
        {
            DataReceived(this, new EventArgs());
        }
    }
}
