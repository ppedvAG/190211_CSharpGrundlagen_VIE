﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sockets_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            byte[] uhrzeit = Encoding.Default.GetBytes(DateTime.Now.ToLongTimeString());
            s.SendTo(uhrzeit, new IPEndPoint(IPAddress.Loopback, 9999));


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
