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
            TcpClient client = new TcpClient("localhost", 7);
            using (StreamWriter sw = new StreamWriter(client.GetStream()))
            {
                string incommingstring = Console.ReadLine();
                using StreamReader sr = new StreamReader(client.GetStream()))
                {
                    Console.WriteLine($"string in ={incommingstring}");

                    sw.WriteLine(incommingstring);
                    sw.Flush();
                }

            }
        }
    }
}
}
