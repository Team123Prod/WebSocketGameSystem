using GameSystem.Models;

namespace GameSystem.Game
{
    public class TypeGameFactory
    {
        public static IType getTypeOfGame(string tp)
        {
            IType typeGame = null;
            switch (tp)
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
