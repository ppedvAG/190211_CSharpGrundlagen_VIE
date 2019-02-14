using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            s.Bind(new IPEndPoint(IPAddress.Loopback, 9999));

            // warten:

            while (true) // Endlosschleife
            {
                byte[] buffer = new byte[1024];
                int totalBytes = s.Receive(buffer, 1024, SocketFlags.None);
                string message = Encoding.Default.GetString(buffer, 0, totalBytes);
                Console.WriteLine(message);
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
