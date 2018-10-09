using System;

namespace TCPServer1
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new Server(7);
            server.Start();
            Console.ReadKey();

        }
    }
}
