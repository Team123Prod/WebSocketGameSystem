using System;
using GameSystem.Game;
using GameSystem.Models;
using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace GameSystem
{
    public class Server: WebSocketBehavior
    {
        protected override void OnOpen()
        {
            Console.WriteLine("Server start..");
        }
        protected override void OnMessage(MessageEventArgs e)
        {
            Request requstObject = JsonConvert.DeserializeObject<Request>(e.Data);
            TicTacToe tic = new TicTacToe();
            tic.Start(requstObject._idMove);
            Sessions.Broadcast(requstObject._idMove.ToString());
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
