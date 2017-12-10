using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Models
{
    class Response
    {
        public string Module { get; set; }
        public string Cmd { get; set; }
        public dynamic Args { get; set; }
        public string Token { get; set; }
    }
}
