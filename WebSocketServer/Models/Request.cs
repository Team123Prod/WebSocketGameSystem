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
}
