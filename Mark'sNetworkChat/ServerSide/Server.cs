using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Chat
{
    public class Server
    {
        // Deklarace promennych
        private static List<User> _onlineUsers; // Pripojeni uzivatele
        private NetworkStream _netStream; // pripojeni
        private CommandDispatcher _dispatcher; // Ruzne metody pro praci s daty
        private TcpListener _listener;

        public Server()
        {
            // priprava servu v konstruktoru, nastaveni promennych atd...
            _onlineUsers = new List<User>();
            _dispatcher = new CommandDispatcher();
            //Task.Run(() => startServer());
            //startServer();
        }

        // static metoda pro jine tridy abychom mohli dostat uzivatele
        public static List<User> GetUsers()
        {
            return _onlineUsers;
        }

        // spusteni serveru
        private async Task startServer()
        {
            // spusteni na portu 3559
            TcpListener listener = new TcpListener(IPAddress.Any, 3559);
            _listener = listener;
            listener.Start();
        }

        // pridani uzivatele
        public void AddUser(NetworkStream stream, Form1 form)
        {
            // vytvoreni noveho objektu uzivatele
            User newUser = new User(stream);

            // pridani do listu
            _onlineUsers.Add(newUser);
            form.AddUserMessage();
        }

        public void RemoveUser(NetworkStream networkStream)
        {
            _onlineUsers.Remove(_onlineUsers.Find(user => user.GetNetworkStream() == networkStream));
        }

        public NetworkStream GetNetworkStream()
        {
            return _netStream;
        }

        public TcpListener GetTcpListener()
        {
            return _listener;
        }

        public CommandDispatcher GetCommandDispatcher()
        {
            return _dispatcher;
        }
    }
}
