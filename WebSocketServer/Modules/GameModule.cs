using GameSystem.Models;
using WebSocketSharp.Server;
using Newtonsoft.Json;
using System.Collections.Generic;
using GameSystem.Game;

namespace GameSystem.Modules
{
    public class GameModule : WebSocketBehavior
    {
        private List<Room> listOfRooms { get; set; }
        private List<Player> listOfPlayers { get; set; }
        public void Dispach(Request request)
        {
            switch (request.Cmd)
            {
                case "CreateRoom":
                    CreateRoom((IType)request.Args, (IType)request.Args);
                    break;
                case "Move":
                    Move(request);
                    break;
            }
        }

        public void CreateRoom(IType typeOfGame, Player player)
        {
            listOfRooms.Add(new Room(typeOfGame, player));
        }
        public void AddPlayer(Player player)
        {
            listOfPlayers.Add(player);
        }
        public void Move(Request request)
        {
            string req = JsonConvert.SerializeObject(new Request("GameModule", "move", request.Args));
            Send(req);
        }
    }
}
