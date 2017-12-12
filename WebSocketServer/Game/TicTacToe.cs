using GameSystem.Models;
using GameSystem.States;
using System.Collections.Generic;
using WebSocketSharp.Server;

namespace GameSystem.Game
{
    public class TicTacToe : WebSocketBehavior, IType
    {
        private List<Player> _listOfPlayers;
        private GameStates _gameState { get; set; }
        public static int _idRoom;
        private string[] _t = new string[] {
                "0", "0", "0",
                "0", "0", "0",
                "0", "0", "0"
                };
       

        public TicTacToe()
        {

        }

        public void Create(Player player, Server websocket)
        {
            throw new System.NotImplementedException();
        }

        public void Move(Player player, int move, Server websocket)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeState()
        {
            throw new System.NotImplementedException();
        }
    }
}
