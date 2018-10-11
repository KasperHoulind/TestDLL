using System;

namespace TCPClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client TCPClient = new Client();

            TCPClient.Start();
            Console.ReadLine();
        }
    }
}
