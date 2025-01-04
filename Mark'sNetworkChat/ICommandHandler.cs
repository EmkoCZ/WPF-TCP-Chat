﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Chat
{
    public interface ICommandHandler
    {
        // Interface pro prikazy
        // data a networkStream pro prozeznani uzivatele co poslal prikaz
        void Handle(string data, NetworkStream networkStream); // zpracuj data...
    }
}
