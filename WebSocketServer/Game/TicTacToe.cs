using GameSystem.Models;
using GameSystem.States;
using Newtonsoft.Json;
using System.Collections.Generic;
//using WebSocketSharp;
using WebSocketSharp.Server;

namespace GameSystem.Game
{
    public class TicTacToe : IType
    {
        private Player _player1;
        private Player _player2;
        private string _markPlayer1;
        private string _markPlayer2; 
        private GameStates _gameState { get; set; }
        public int _idRoom;
        public string _result;
        private int _count = 0;
        private string[] _t = new string[] {
                "0", "0", "0",
                "0", "0", "0",
                "0", "0", "0"
                };


        public TicTacToe()
        {

        }

        public void Connect(Player player, Server websocket)
        {
            player.idRoom = _idRoom;
            _player2 = player;
            dynamic Ar = new object();
            Ar.mark = "O";
            Request response = new Request("GameModule", "GameResponse", Ar);
            string json = JsonConvert.SerializeObject(response);
            websocket.SendResponse(json);

        }
        public void Create(Player player, Server websocket)
        {
            _idRoom = player.idRoom;
            _player1 = player;
            dynamic Ar = new object();
            Ar.mark = "X";
            Request request = new Request("GameModule", "GameResponse", Ar);
            string json = JsonConvert.SerializeObject(request);
            websocket.SendResponse(json);
        }

        public void Move(Player player, int move, Server websocket)
        {
            Request request;
            string mark = "";
            if (_player1 == player)
                mark = _markPlayer1;
            else
                mark = _markPlayer2;
            _t[move] = mark;
            _count++;
            if (IsOver())
            {
                dynamic Ar = new object();
                Ar.move = move;
                Ar.mark = mark;
                request = new Request("GameModule", "Move", Ar);
                request = new Request ("GameModule", "Over", Ar);
                string json = JsonConvert.SerializeObject(request);
                websocket.SendResponse(json);
            }
            else
            {
                dynamic Ar = new object();
                Ar.move = move;
                Ar.mark = mark;
                request = new Request("GameModule", "Move", Ar);
                string json = JsonConvert.SerializeObject(request);
                websocket.SendResponse(json);
            }
        }

        public bool IsOver()
        {
            bool stateGAme = false;

            if (_t[0] == "X" && _t[1] == "X" && _t[2] == "X" || _t[0] == "O" && _t[1] == "O" && _t[2] == "O") stateGAme = true;
            if (_t[3] == "X" && _t[4] == "X" && _t[5] == "X" || _t[3] == "O" && _t[4] == "O" && _t[5] == "O") stateGAme = true;
            if (_t[6] == "X" && _t[7] == "X" && _t[8] == "X" || _t[6] == "O" && _t[7] == "O" && _t[8] == "O") stateGAme = true;
            if (_t[0] == "X" && _t[3] == "X" && _t[6] == "X" || _t[0] == "O" && _t[3] == "O" && _t[6] == "O") stateGAme = true;
            if (_t[1] == "X" && _t[4] == "X" && _t[7] == "X" || _t[1] == "O" && _t[4] == "O" && _t[7] == "O") stateGAme = true;
            if (_t[2] == "X" && _t[5] == "X" && _t[8] == "X" || _t[2] == "O" && _t[5] == "O" && _t[8] == "O") stateGAme = true;
            if (_t[0] == "X" && _t[4] == "X" && _t[8] == "X" || _t[0] == "O" && _t[4] == "O" && _t[8] == "O") stateGAme = true;
            if (_t[2] == "X" && _t[4] == "X" && _t[6] == "X" || _t[2] == "O" && _t[4] == "O" && _t[6] == "O") stateGAme = true;
            if (_count == 9) stateGAme = true;

            return stateGAme;
        }
    }
}
