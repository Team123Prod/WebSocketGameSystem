﻿using GameSystem.Models;

namespace GameSystem.Game
{
    public class TypeGameFactory
    {
        static IType getTypeOfGame(Request req)
        {
            IType typeGame = null;
            switch (req.Cmd)
            {
                case "TicTacToe":
                    typeGame = new TicTacToe();
                    break;
                default:
                    break;

            }
            return typeGame;
        }
    }
}