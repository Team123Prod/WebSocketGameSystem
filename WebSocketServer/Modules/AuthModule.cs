using System;
using GameSystem.Models;

namespace GameSystem.Modules
{
    public class AuthModule
    {
        public void Dispach(Request request)//сюда свои параметры Client client, RequestObject info, List<Client> clientsList)
        {
            switch (request.Cmd)
            {
                case "Login":
                    Console.WriteLine(request.Module + request.Cmd);
                    break;
                case "Logout":
                    break;
                case "Registration":
                    break;
            }
        }
    }
}
