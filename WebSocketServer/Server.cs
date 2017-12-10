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
        //public List<WebSocketBehavior> ListOfWebSocketBehaviors = new List<WebSocketBehavior>();
        
        protected override void OnOpen()
        {
            Console.WriteLine("Client joined..");
            //ListOfWebSocketBehaviors.Add(this);
        }
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine(e.Data);
            Request requstObject = JsonConvert.DeserializeObject<Request>(e.Data);
            //_modulesDispatcher.Distribute(request);
            _dispatcher.Distribute(requstObject, this);
            //Sessions.Broadcast(requstObject.Args.ToString());
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
