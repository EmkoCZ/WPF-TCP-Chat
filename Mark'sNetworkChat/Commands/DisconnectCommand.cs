using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Chat.Commands
{
    public class DisconnectCommand : ICommandHandler
    {
        public void Handle(string data, NetworkStream networkStream)
        {
            // odpojeni uzivatele
            Form1.server.RemoveUser(networkStream);
        }
    }
}
