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
            listOfPlayers.Add(request.Args.player);
            _typeOfGame = TypeGameFactory.getTypeOfGame(request.Args.typeGame);
            _typeOfGame.Create(request.Args.player, websocket);

        }

        public void Move(Player player, int move, Server websocket)
        {
            _typeOfGame.Move(player, move, websocket);
        }
    }
}
