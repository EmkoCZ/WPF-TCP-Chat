using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCP_Chat.Commands;

namespace TCP_Chat
{
    public class CommandDispatcher
    {
        // Dictionary pro vsechny nase prikazy
        private readonly Dictionary<string, ICommandHandler> _handlers;

        public CommandDispatcher()
        {
            // nastaveni handlers
            _handlers = new Dictionary<string, ICommandHandler>();
            // pridani nasich prikazu
            _handlers.Add("username", new UsernameCommand()); // pro nastaveni username uzivatele
            _handlers.Add("message", new MessageCommand()); // pro poslani zpravy vsem uzivatelu
            _handlers.Add("disconnect", new DisconnectCommand()); // pro odpojeni uzivatele
        }

        // zpracuj data prikazu
        public void Dispatch(string data, NetworkStream networkStream)
        {
            // data serveru jsou rozdelena takto: typ/data
            // typ je prikaz
            var parts = data.Split('/'); // rozdel na typ a data
            var command = parts[0]; // prikaz je [0]
            _handlers.TryGetValue(command, out ICommandHandler handler); // najdi prikaz co pouziva typ command
            handler.Handle(data, networkStream); // prikaz zpracuje data
        }

        //NOTE Tento zpusob prikazu jsem chtel proto aby vsechna logika serveru nebyla
        //    v jedne tride, ale bylo to trochu organizovane
    }
}
