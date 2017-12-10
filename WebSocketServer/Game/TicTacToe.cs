using GameSystem.Models;
using GameSystem.States;
using System.Collections.Generic;
using WebSocketSharp.Server;

namespace GameSystem.Game
{
    public class TicTacToe : WebSocketBehavior, IType
    {
        private List<Player> _listOfPlayers;
        private string[] _t = new string[] {
                "0", "0", "0",
                "0", "0", "0",
                "0", "0", "0"
                };
        private GameStates _gameState { get; set; }
        public static int _idRoom;

        public TicTacToe()
        {

        }

        public void Create(int idRoom, Player player)
        {
            _listOfPlayers.Add(player);

        }

        public void createRoom()
        {
            //Room room = new Room();
        }

        
        private void Move(int move, string role)
        {
            _idMove = id;
            if (t[id] == "0") return;
            t[id] = role;
            if (checkEnd() && role == "player")
                OnOpen();
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public void Move()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeState()
        {
            throw new System.NotImplementedException();
        }
    }
}
