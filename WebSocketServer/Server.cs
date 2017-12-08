using System;
using GameSystem.Controllers;
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
        readonly ModulesDispatcher _modulesDispatcher = new ModulesDispatcher();
        ModulesDispatcher dispatcher = new ModulesDispatcher();
        protected override void OnOpen()
        {
            Console.WriteLine("Client joined..");
        }
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine(e.Data);
            Request request = JsonConvert.DeserializeObject<Request>(e.Data);
            _modulesDispatcher.Distribute(request);
            dispatcher.Distribute(requstObject);

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
    }
}
