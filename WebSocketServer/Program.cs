using System;

namespace GameSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var wssv = new WebSocketSharp.Server.WebSocketServer("ws://localhost:8881/");
            wssv.AddWebSocketService<Server>("/Server");
            wssv.Start();
            Console.ReadKey(true);
            wssv.Stop();
        }
        

    }
}
