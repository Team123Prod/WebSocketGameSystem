using GameSystem.Models;
using WebSocketSharp.Server;
using Newtonsoft.Json;
using System.Collections.Generic;
using GameSystem.Game;

namespace GameSystem.Modules
{
    public class GameModule : WebSocketBehavior
    {
        private List<Room> _listOfRooms { get; set; }
        private List<Player> _listOfPlayers { get; set; }
        public void Dispach(Request request, Server webSocket)
        {
            switch (request.Cmd)
            {
                case "CreateRoom":
                    CreateRoom(request, webSocket);
                    break;
                case "Move":
                    Move(request, webSocket);
                    break;
            }
        }

        public void CreateRoom(Request request, Server websocket)
        {
            _listOfPlayers.Add(request.Args.player);
            _listOfRooms.Add(new Room(request, websocket));
        }
        public void Move(Request request, Server websocket)
        {
            Room room = GetRoomById(request.Args.idRoom);
        }
        private Room GetRoomById(int idRoom)
        {
            Room room = null;
            foreach(Room r in _listOfRooms)
            {
                if (r.id == idRoom)
                    room = r;
            }
            return room;
        }
    }
}
