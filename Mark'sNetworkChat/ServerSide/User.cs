using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Chat
{
    public class User
    {
        // pripojeni uzivatele
        private NetworkStream _netStream;
        // jeho username
        private string _username;

        public User(NetworkStream networkStream)
        {
            // nastaveni streamu pri vytvoreni uzivatele
            _netStream = networkStream;
        }

        // ziskani jeho streamu
        public NetworkStream GetNetworkStream()
        {
            return _netStream;
        }

        // nastaveni username | UsernameCommand
        public void SetUsername(string username)
        {
            this._username = username;
        }

        // ziskani jeho username
        public string GetUsername()
        {
            return _username;
        }
    }
}
