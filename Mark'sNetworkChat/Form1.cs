using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TCP_Chat
{
    public partial class Form1 : Form
    {
        // mouse lokace, serverSide a clientSide trida
        private Point _mouseLocation; 
        public static Client client;
        public static Server server;

        public Form1()
        {
            // nastaveni do zacatecniho stavu
            InitializeComponent();
            namePanel.Enabled = false;
            namePanel.Visible = false;
            chatPanel.Visible = false;
            chatPanel.Enabled = false;
            connectingLbl.Visible = false;
            messagePanel.Enabled = false;
            messagePanel.Visible = false;
        }

        // odpojeni od serveru a zavreni aplikace
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (client != null && client.IsConnected())
            {
                TCPFunctions.Write(client.GetNetworkStream(), Encoding.UTF8.GetBytes("message/" + nameInput.Text + " ztratil připojení k serveru."), client.GetContentHandler());
                client.Disconnect();
            }
            this.Close();
        }

        // pohyb oknem
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        // pohyb oknem
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(_mouseLocation.X, _mouseLocation.Y);
                Location = mousePose;
            }
        }

        // update chatu
        private async Task StartClientHandler(NetworkStream stream)
        {
            while (true)
            {
                if(stream != null)
                {
                    if (client.IsConnected())
                    {
                        if (stream.DataAvailable)
                        {
                            byte[] data = TCPFunctions.ReadToEnd(stream);
                            this.Invoke(new Action(() => chatBox.AppendText(Encoding.UTF8.GetString(data) + "\n")));
                        }
                        else Thread.Sleep(1);
                    }
                }
            }
        }

        // update chatu (zpravy od uzivatelu)
        private void StartServerHandler(NetworkStream stream)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 3559);
            listener.Start();

            // chceme neustale prijimat data, proto while true
            while (true)
            {
                // Prijmuti pripojeni od uzivatele
                //TcpListener listener = server.GetTcpListener();
                TcpClient client = listener.AcceptTcpClient();
                // Pridani uzivatele do listu asynchrone
                Task.Run(() => server.AddUser(client.GetStream(), this));

                NetworkStream clientStream = client.GetStream();
                //_netStream = stream;

                Task.Run(() =>
                {
                    while (true)
                    {
                        // Pokud jsou dostupna data
                        if (clientStream.DataAvailable)
                        {
                            // nacti prichozi data
                            byte[] receivedBytes = TCPFunctions.ReadToEnd(clientStream);
                            // byte[] na citelny string
                            string streamData = Encoding.UTF8.GetString(receivedBytes);
                            // vypis prichozi data
                            Console.WriteLine(streamData);
                            // zpracuj prichozi data
                            server.GetCommandDispatcher().Dispatch(streamData, clientStream);

                            User user = UsersHelper.GetUserByNetStream(clientStream);
                            this.Invoke(new Action(() => chatBox.AppendText(user.GetUsername() + "->" + streamData + "\n")));
                        }
                        // Thread sleep pro odlechceni procesoru | aby program byl mene narocny aspon o trochu
                        else Thread.Sleep(10);
                    }
                });
            }
        }

        // odeslani zpravy po stisknuti enteru
        private void chatInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TCPFunctions.Write(client.GetNetworkStream(), Encoding.UTF8.GetBytes("message/" + chatInput.Text), client.GetContentHandler());
                chatInput.Clear();
            }
        }

        // zobrazeni chatu
        private void chatBtn_Click(object sender, EventArgs e)
        {
            namePanel.Enabled = false;
            namePanel.Visible = false;
            messagePanel.Enabled = true;
            messagePanel.Visible = true;
            chatBox.Visible = true;
        }

        // pripojeni k serveru
        private async void connectBtn_Click(object sender, EventArgs e)
        {
            if(ipInput.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid IP address");
                return;
            }
            connectingLbl.Visible = true;
            await Task.Run(() => createClient(ipInput.Text));

            if (client.IsConnected())
            {
                conncetionPanel.Enabled = false;
                conncetionPanel.Visible = false;
                namePanel.Enabled = true;
                namePanel.Visible = true;
            }
        }

        // pripojeni k localhost serveru
        private async void localhostBtn_Click(object sender, EventArgs e)
        {
            connectingLbl.Visible = true;
            await Task.Run(() => createClient("127.0.0.1"));

            if (client.IsConnected())
            {
                conncetionPanel.Enabled = false;
                conncetionPanel.Visible = false;
                namePanel.Enabled = true;
                namePanel.Visible = true;
            }
        }

        // vytvoreni klienta
        private async Task createClient(string ipAddress)
        {
            client = new Client();
            await client.ConnectToServer(ipInput.Text);
        }

        // ulozeni jmena a aktualizace na serveru
        private async void saveNameBtn_Click(object sender, EventArgs e)
        {
            if(client != null)
            {
                client.SetUsername(nameInput.Text);
                namePanel.Enabled = false;
                namePanel.Visible = false;
                chatPanel.Enabled = true;
                chatPanel.Visible = true;
                messagePanel.Enabled = true;
                messagePanel.Visible = true;
                await Task.Run(() => StartClientHandler(client.GetNetworkStream()));
            }
        }

        // spusteni serveru
        private async void serverStartBtn_Click(object sender, EventArgs e)
        {
            serverStatusLbl.Visible = true;
            server = new Server();
            conncetionPanel.Enabled = false;
            conncetionPanel.Visible = false;
            chatPanel.Enabled = true;
            chatPanel.Visible = true;
            await Task.Run(() => StartServerHandler(server.GetNetworkStream()));
        }

        // poslani zparvy do konzole serveru o pripojeni
        public void AddUserMessage()
        {
            this.Invoke(new Action(() => chatBox.AppendText("Added user\n")));
        }
    }
}
