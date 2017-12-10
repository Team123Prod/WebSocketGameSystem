using GameSystem.DAO;
using GameSystem.DbMock;
using Newtonsoft.Json.Linq;

namespace GameSystem.Models
{
    public class Request
    {
        public Request()
        {

        }
        public Request(string module, string cmd, dynamic args)
        {
            this.Module = module;
            this.Cmd = cmd;
            this.Args = args;
        }

        public string Module { get; set; }
        public string Cmd { get; set; }
        public dynamic Args { get; set; }
        public string Token { get; set; }
        public UserStatus UserStatus { get; set; } = UserStatus.Guest;


        public void DefineUserStatus()
        {
            IUserAccountDAO db = new UserAccountDAO_Mock();
            if (db.GetUserByLogin(TokenProvider.GetLogin(Token)) != null)
            {
                UserStatus = UserStatus.Authorized;
            }
        }
    }

    //public class Request
    //{
    //    public string _cmd;
    //    public string _module;
    //    public Player _player;
    //    public int _idRoom;
    //    public int _idMove;

    //    public Request(string cmd, string module, int idRoom, Player player, int idMove)
    //    {
    //        _cmd = cmd;
    //        _module = module;
    //        _idRoom = idRoom;
    //        _player = player;
    //        _idMove = idMove;
    //    }
    //}
}
