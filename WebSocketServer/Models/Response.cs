using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Models
{
    class Response
    {
        public Response()
        {

        }
        public Response(string module, string cmd, dynamic args)
        {
            this.Module = module;
            this.Cmd = cmd;
            this.Args = args;
        }

        public string Module { get; set; }
        public string Cmd { get; set; }
        public dynamic Args { get; set; } = new Object();
        public string Token { get; set; } = "";
    }
}
