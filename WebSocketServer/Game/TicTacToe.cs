using GameSystem.Models;
using GameSystem.States;
using WebSocketSharp.Server;

namespace GameSystem.Game
{
    public class TicTacToe : WebSocketBehavior, IType
    {
        private Player _player1;
        private Player _player2;
        private string[] t = new string[] {
                "0", "0", "0",
                "0", "0", "0",
                "0", "0", "0"
                };
        private GameStates _gameState { get; set; }
        public static int _idMove;

        public TicTacToe()
        {

        }
        public TicTacToe(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void Start(int idMove)
        {
            //Send(idMove.ToString());
            Sessions.Broadcast(idMove.ToString());
        }

        public void createRoom()
        {
            //Room room = new Room();
        }

        private void ai(int id)
        {
            if (t[id] != "ai")
            {
                Move(id, "ai");
            }
        }
        private void aiBot()
        {
            var id = 0;
            // t[id] ? aiBot()Math.Floor(Math.r() * 9) : move(id, "ai");
        }

        private bool checkEnd()
        {
            if (t[0] == "ai" && t[1] == "ai" && t[2] == "ai" || t[0] == "player" && t[1] == "player" && t[2] == "player") return true;
            if (t[3] == "ai" && t[4] == "ai" && t[5] == "ai" || t[3] == "player" && t[4] == "player" && t[5] == "player") return true;
            if (t[6] == "ai" && t[7] == "ai" && t[8] == "ai" || t[6] == "player" && t[7] == "player" && t[8] == "player") return true;
            if (t[0] == "ai" && t[3] == "ai" && t[6] == "ai" || t[0] == "player" && t[3] == "player" && t[6] == "player") return true;
            if (t[1] == "ai" && t[4] == "ai" && t[7] == "ai" || t[1] == "player" && t[4] == "player" && t[7] == "player") return true;
            if (t[2] == "ai" && t[5] == "ai" && t[8] == "ai" || t[2] == "player" && t[5] == "player" && t[8] == "player") return true;
            if (t[0] == "ai" && t[4] == "ai" && t[8] == "ai" || t[0] == "player" && t[4] == "player" && t[8] == "player") return true;
            if (t[2] == "ai" && t[4] == "ai" && t[6] == "ai" || t[2] == "player" && t[4] == "player" && t[6] == "player") return true;
            //if (t.eq) return true;
            return false;
        }
        private void Move(int id, string role)
        {
            _idMove = id;
            if (t[id] == "0") return;
            t[id] = role;
            if (checkEnd() && role == "player")
                OnOpen();
        }
    }
}
