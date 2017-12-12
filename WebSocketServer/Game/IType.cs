using GameSystem.Models;

namespace GameSystem.Game
{
    public interface IType
    {
        void Create(Player player, Server websocket);
        void Move(Player player, int move, Server websocket);
        void ChangeState();


    }
}
