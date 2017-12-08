using GameSystem.Models;
using WebSocketSharp.Server;
using Newtonsoft.Json;

namespace GameSystem.Modules
{
    public class GameModule : WebSocketBehavior
    {
        public void Dispach(Request request)//сюда свои параметры Client client, RequestObject info, List<Client> clientsList)
        {
            switch (request.Cmd)
            {
                case "startGame":
                    start(request);
                    break;
                case "move":
                    move(request);
                    break;
            }
        }
        public void start(Request request)
        {
            string req = JsonConvert.SerializeObject(new Request("GameModule", "GameStarted", request.Args));
            Send(req);
        }
        public void move(Request request)
        {
            string req = JsonConvert.SerializeObject(new Request("GameModule", "move", request.Args));
            Send(req);
        }
    }
}
