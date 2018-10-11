using System;
//using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TestDLL;

namespace TCPServer1
{
    class Server
    {
        private int _port;

        public Server(int port)
        {
            _port = port;
        }

        public void Start()
        {
            var listener = new TcpListener(IPAddress.Loopback, _port);
            listener.Start();
            while (true)
            {
                var client = listener.AcceptTcpClient();
                Task.Run(() => DoClient(client));
            }

            
        }
        private void DoClient(TcpClient client)
        {
            Console.WriteLine("Waiting for Client");
            while (client.Connected)
            {
                var ns = client.GetStream();
                var sr = new StreamReader(ns);
                var sw = new StreamWriter(ns);
                sw.AutoFlush = true;
                string[] incStrings;

                incStrings = sr.ReadLine().Split(' ');

                Convert1Dll Convert = new Convert1Dll();

                string ConvertOptions = incStrings[0];
                if (ConvertOptions == "OzToGram")
                {
                    double grams = double.Parse(incStrings[1]);
                    double result = Convert.OzToGrams(grams);
                    System.Console.WriteLine(result);
                    sw.WriteLine(result);

                    
                }

                else if (ConvertOptions == "GramsToOz")
                {
                    double oz = double.Parse(incStrings[1]);
                    double result = Convert.GramsToOz(oz);
                    sw.WriteLine(result);
                }

                sw.Flush();
            } 

        }


    }

}


