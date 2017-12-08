using System;
using GameSystem.Game;
using GameSystem.Models;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;
using GameSystem.Controllers;

namespace GameSystem
{
    public class Server: WebSocketBehavior
    {
        ModulesDispatcher dispatcher = new ModulesDispatcher();
        protected override void OnOpen()
        {
            Console.WriteLine("Client joined..");
        }
        protected override void OnMessage(MessageEventArgs e)
        {
            Request requstObject = JsonConvert.DeserializeObject<Request>(e.Data);
            dispatcher.Distribute(requstObject);

        }
        protected override void OnClose(CloseEventArgs e)
        {
            base.OnClose(e);
        }
        protected override void OnError(ErrorEventArgs e)
        {
            base.OnError(e);
        }
    }
}
