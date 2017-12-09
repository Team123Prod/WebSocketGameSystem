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
                    Start(request);
                    break;
                case "move":
                    Move(request);
                    break;
            }
        }
        public void Start(Request request)
        {
            string req = JsonConvert.SerializeObject(new Request("GameModule", "GameStarted", request.Args));
            Send(req);
        }
        public void Move(Request request)
        {
            string req = JsonConvert.SerializeObject(new Request("GameModule", "move", request.Args));
            Send(req);
        }
    }
}
