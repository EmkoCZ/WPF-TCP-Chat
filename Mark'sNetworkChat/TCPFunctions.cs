using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP_Chat
{
    public static class TCPFunctions
    {
        // Metoda na cteni dat
        public static byte[] ReadToEnd(NetworkStream stream)
        {
            // list pro prijate bytes
            List<byte> receivedBytes = new List<byte>();

            // Pokud jsou dostupna data v networkStreamu...
            while (stream.DataAvailable)
            {
                // byte[] pro nase data
                byte[] buffer = new byte[1024];
                // nacteme data ze streamu do bufferu
                stream.Read(buffer, 0, buffer.Length);
                // pak pridame data z bufferu do receivedBytes
                receivedBytes.AddRange(buffer);
            }

            // pokud jsou tam data ktera jsou prazdna, smaz je
            receivedBytes.RemoveAll(b => b == 0);
            // vrat vysledna nactena data
            return receivedBytes.ToArray();
        }

        // Metoda na poslani zpravy do serveru
        public static void Write(NetworkStream stream, byte[] data, ContentHandler contentHandler)
        {
            try
            {
                // posli data
                stream.Write(data, 0, data.Length);
            }
            catch (Exception)
            {
                // ztraceno pripojeni k server
                contentHandler.Handle("LOST CONNECTION TO SERVER");
            }
        }
    }
}
