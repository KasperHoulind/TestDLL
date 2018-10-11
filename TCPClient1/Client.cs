using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace TCPClient1
{
    class Client
    {

        public void Start()
        {
            var client = new TcpClient("localhost",7);

            while (true)
            {
                var ns = client.GetStream(); 
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);
                sw.AutoFlush = true;

                sw.WriteLine(Console.ReadLine());
                Console.WriteLine(sr.ReadLine());
            }


        }
    }
}

