using System.Collections.Generic;
using GameSystem.Game;

namespace GameSystem.Models
{
    public class Room
    {
        public int id;
        private List<Player> listOfPlayers { get; set; }
        public IType _typeOfGame { get; set; }

        public void AddPlayer(string login, IType typeGame)
        {
            listOfPlayers.Add(new Player(login));
        }
        public Room(IType typeOfGame)
        {
            _typeOfGame = typeOfGame;
        }

        public void Move(int move)
        {

        }
        public void Start(int move)
        {

        }
    }
}
