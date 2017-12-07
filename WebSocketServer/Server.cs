using System;
using GameSystem.Controllers;
using GameSystem.Game;
using GameSystem.Models;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace GameSystem
{
    public class Server: WebSocketBehavior
    {
        readonly ModulesDispatcher _modulesDispatcher = new ModulesDispatcher();
        protected override void OnOpen()
        {
            Console.WriteLine("Client joined..");
        }
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine(e.Data);
            Request request = JsonConvert.DeserializeObject<Request>(e.Data);
            _modulesDispatcher.Distribute(request);

            //TicTacToe tic = new TicTacToe();
            //tic.Start(requstObject._idMove);
            //Sessions.Broadcast(requstObject._idMove.ToString());
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
