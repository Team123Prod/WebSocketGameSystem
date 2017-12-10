using System;
using GameSystem.DAO;
using GameSystem.DbMock;
using GameSystem.Models;
using Newtonsoft.Json.Linq;
using WebSocketSharp.Server;

namespace GameSystem.Modules
{
    public class AuthModule
    {
        public void Dispach(Request request, Server webSocket)//сюда свои параметры Client client, RequestObject info, List<Client> clientsList)
        {
            //Response response = null;
            switch (request.Cmd)
            {
                case "Login":
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
                            webSocket.SendResponse("Error: invalid login");
                        else
                        {
                            if (string.Compare(account.Password, password) == 0)
                            {
                                webSocket.SendResponse(TokenProvider.GetToken(account.Login));
                            }
                            else
                            {
                                webSocket.SendResponse("Error: invalid password");
                            }
                        }
                        //find login and pasw in Db
                        //webSocket.SendResponse(TokenProvider.GetToken());
                    }
                    break;
                case "Logout":
                    break;
                case "Registration":
                    break;
            }
        }
    }
}
