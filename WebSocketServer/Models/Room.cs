using System.Collections.Generic;
using GameSystem.Game;

namespace GameSystem.Models
{
    public class Room
    {
        public int id;
        private List<Player> listOfPlayers { get; set; }
        public string _typeOfGame { get; set; }

        public void AddPlayer(string login, IType typeGame)
        {
            listOfPlayers.Add(new Player(login));
        }
        public Room(string typeOfGame)
        {
            _typeOfGame = typeOfGame;
        }
    }
}
