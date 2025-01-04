using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Chat.Commands
{
    public class MessageCommand : ICommandHandler
    {
        public void Handle(string data, NetworkStream networkStream)
        {
            // zprava kterou pak posleme vsem uzivatelum
            string message = UsersHelper.GetUserByNetStream(networkStream).GetUsername() + ": " + data.Split('/')[1];
            // List odpojenych uzivatelu
            List<User> disconnectedUsers = new List<User>();
            foreach (var user in Server.GetUsers())
            {
                // Vsem uzivatelum posli zpravu
                try
                {
                    user.GetNetworkStream().Write(Encoding.UTF8.GetBytes(message), 0, message.Length);
                }
                catch (Exception)
                {
                    // Pokud je pripojeni s uzivatelem spatne nebo se odpojil,
                    // pridej ho do listu
                    disconnectedUsers.Add(user);
                }
            }

            // Vsechny opdojene uzivatele smaz z listu onlineUsers na Serveru
            if (disconnectedUsers.Count > 0)
            {
                foreach (var user in disconnectedUsers)
                {
                    Server.GetUsers().Remove(user);
                    Console.WriteLine("User " + user.GetUsername() + " has disconnected");
                }
            }
        }
    }
}
