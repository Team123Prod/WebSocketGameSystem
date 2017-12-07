using System.Collections.Generic;

namespace GameSystem.Models
{
    public class Game
    {
        private List<Room> listOfRooms { get; set; }
        private List<Player> listOfPlayers { get; set; }

        public void CreateRoom(string typeOfGame)
        {
            listOfRooms.Add(new Room(typeOfGame));
        }
        public void AddPlayer(Player player)
        { 
            listOfPlayers.Add(player);
        }

    }
}
