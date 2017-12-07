using GameServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.DAO
{
    interface IUserAccountDAO
    {
        void Create(UserAccount p);
        void Delete(UserAccount p);
        List<UserAccount> Read();
        void Update(UserAccount p);
    }
}
