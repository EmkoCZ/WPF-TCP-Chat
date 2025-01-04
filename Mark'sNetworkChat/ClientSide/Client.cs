using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCP_Chat
{
    public class Client
    {
        // Deklarace promennych
        private NetworkStream _networkStream; // stream dat/propojeni se serverem
        private TcpClient _client; // nas TCP klient
        private ContentHandler _contentHandler; // Handler na content
        private string _username; // uzivatelske jmeno

        public Client()
        {
            // Nastaveni hodnot a priprava title v konstruktoru
            _contentHandler = new ContentHandler();
        }

        public async Task ConnectToServer(string ipAddress)
        {
            try
            {
                // pokusime se navazat spojeni se serverem
                _client = new TcpClient(ipAddress, 3559);
                _networkStream = _client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to server with IP: " + ipAddress + "\n");
            }

            //chooseUsername();
            //getMessages();
        }

        public bool IsConnected()
        {
            if (_client != null)
            {
                return _client.Connected;
            }
            else return false;
        }

        public void Disconnect()
        {
            //TCPFunctions.Write(_networkStream, Encoding.UTF8.GetBytes("disconnect/"), _contentHandler);
            _networkStream.Close();
            _client.Close();
        }

        public void SetUsername(string username)
        {
            _username = username;
            TCPFunctions.Write(_networkStream, Encoding.UTF8.GetBytes("username/" + username), _contentHandler);
        }

        public string GetUsername()
        {
            return _username;
        }

        public NetworkStream GetNetworkStream()
        {
            return _networkStream;
        }

        public ContentHandler GetContentHandler()
        {
            return _contentHandler;
        }
    }
}
