using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSystem.Game;
using GameSystem.Models;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Net.WebSockets;
using WebSocketSharp.Server;

namespace GameSystem
{
    public class Server: WebSocketBehavior
    {
        readonly ModulesDispatcher _dispatcher = new ModulesDispatcher();
        
        protected override void OnOpen()
        {
            Console.WriteLine("Client joined..");
        }
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine(e.Data);
            Request requstObject = JsonConvert.DeserializeObject<Request>(e.Data);
            _dispatcher.Distribute(requstObject, this);
        }
        protected override void OnClose(CloseEventArgs e)
        {
            base.OnClose(e);
            Console.WriteLine("Client leaved..");
        }
        protected override void OnError(ErrorEventArgs e)
        {
            base.OnError(e);
        }

        public void SendResponse(string response)
        {
            Send(response);
        }
    }
}
