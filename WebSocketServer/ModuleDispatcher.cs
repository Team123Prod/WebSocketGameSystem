using System;
using GameSystem.Models;
using GameSystem.Modules;
using WebSocketSharp.Server;

namespace GameSystem
{
    public class ModulesDispatcher
    {
        public void Distribute(Request request, Server webSocket)
        {
            request.DefineUserStatus();
            Console.WriteLine("UserStatus: " + request.UserStatus);
            switch (request.Module)
            {
                case "AuthModule":
                    new AuthModule().Dispach(request, webSocket);
                    break;
                case "ProfileModule":
                    new ProfileModule().Dispach(request);
                    break;
                case "GameModule":
                    new GameModule().Dispach(request);
                    break;
                case "MsgModule":
                    new MsgModule().Dispach(request);
                    break;
                case "RateModule":
                    new RateModule().Dispach(request);
                    break;
            }
        }


    }
}
