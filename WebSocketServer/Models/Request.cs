namespace GameSystem.Models
{
    public class Request
    {
        public Request()
        {

        }
        public Request(string Module, string Cmd, object Args)
        {
            this.Module = Module;
            this.Cmd = Cmd;
            this.Args = Args;
        }

        public string Module { get; set; }
        public string Cmd { get; set; }
        public object Args { get; set; }
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
