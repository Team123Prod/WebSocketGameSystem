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
                    response = new Response();
                    response.Cmd = "Login";
                    if (request.UserStatus == UserStatus.Authorized)
                    {
                        //user is already authorized, just update token
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
                            if (string.Compare(account.Password, password) == 0)
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
                    break;
                case "Logout":
                    break;
                case "Registration":
                    break;
            }
            if (response != null)
            {
                response.Module = "AuthModule";
                string json = JsonConvert.SerializeObject(response);
                webSocket.SendResponse(json);
            }
        }
    }
}
