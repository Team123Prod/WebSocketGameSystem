using System.Collections.Generic;
using GameSystem.Game;

namespace GameSystem.Models
{
    public class Room
    {
        public int id;
        private List<Player> listOfPlayers { get; set; }
        public IType _typeOfGame { get; set; }

        public Room(Request request, Server websocket)
        {
            id = 3;
            request.Args.idRoom = id;
            listOfPlayers.Add(request.Args.player);
            _typeOfGame = TypeGameFactory.getTypeOfGame(request.Args.typeGame);
            _typeOfGame.Create(request.Args.player, websocket);

        }

        public void Move(Request request, Server websocket)
        {
            _typeOfGame.Move(request.Args.player, request.Args.move, websocket);
        }
    }
}
