using System;
using GameSystem.DAO;
using GameSystem.DbMock;
using GameSystem.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebSocketSharp.Server;

namespace GameSystem.Modules
{
    public class AuthModule
    {
        public void Dispach(Request request, Server webSocket)
        {
            dynamic response = null;
            switch (request.Cmd)
            {
                case "Login":
                    response = Authorize(request);
                    break;
                case "Logout":
                    break;
                case "Registration":
                    response = Registration(request);
                    break;
            }
            if (response != null)
            {
                response.Module = "AuthModule";
                string json = JsonConvert.SerializeObject(response);
                webSocket.SendResponse(json);
            }
        }

        private Response Authorize(Request request)
        {
            Response response = new Response { Module = "AuthModule", Cmd = "Login", Token = "" };
            if (request.UserStatus == UserStatus.Authorized)
            {
                string login = TokenProvider.GetLogin(request.Token);
                response.Token = TokenProvider.GetToken(login);
            }
            else
            {
                IUserAccountDAO db = new UserAccountDAO_Mock();
                string login = request.Args.Login;
                string password = request.Args.Password;
                UserAccount account = db.GetUserByLogin(login);
                if (account == null)
                {
                    response.Args = new { Error = "invalid login" };
                }
                else
                {
                    if (account.Password == password)
                    {
                        string token = TokenProvider.GetToken(account.Login);
                        response.Token = token;
                    }
                    else
                    {
                        response.Args = new { Error = "invalid password" };
                    }
                }
            }
            return response;
        }

        private Response Registration(Request request)
        {
            Response response = new Response { Module = "AuthModule", Cmd = "Registration", Token = "" };
            IUserAccountDAO db = new UserAccountDAO_Mock();
            string login = request.Args.Login;
            string password = request.Args.Password;
            string email = request.Args.Email;
            UserAccount account = new UserAccount {Login = login, Password = password, Email = email};
            db.Create(account);
            string token = TokenProvider.GetToken(account.Login);
            response.Token = token;
            return response;
        }
    }
}
