using System.Collections.Generic;
using GameSystem.Models;

namespace GameSystem.DAO
{
    interface IUserAccountDAO
    {
        void Create(UserAccount p);
        void Delete(UserAccount p);
        List<UserAccount> Read();
        void Update(UserAccount p);
        UserAccount GetUserByLogin(string login);
    }
}
