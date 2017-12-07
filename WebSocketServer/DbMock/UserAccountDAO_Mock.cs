using GameServer.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServer.Models;

namespace GameServer.DbMock
{
    public class UserAccountDAO_Mock : IUserAccountDAO
    {
        List<UserAccount> users = null;
        public UserAccountDAO_Mock()
        {
            users = new List<UserAccount>();

            users.Add(new UserAccount() { Id = 1, Email = "v123@gmail.com", Login = "vasya", Password = "1" });
            users.Add(new UserAccount() { Id = 2, Email = "l123@gmail.com", Login = "lola", Password = "2" });
            users.Add(new UserAccount() { Id = 3, Email = "m123@gmail.com", Login = "misha", Password = "3" });
        }
        public void Create(UserAccount p)
        {
            users.Add(p);
        }

        public void Delete(UserAccount p)
        {
            users.RemoveAll(x => x.Id == p.Id);
        }

        public List<UserAccount> Read()
        {
            return users;
        }

        public void Update(UserAccount p)
        {
            foreach (UserAccount u in users)
            {
                if (u.Id == p.Id)
                {
                    u.Email = p.Email;
                    u.Login = p.Login;
                    u.Password = p.Password;
                }
            }
        }
    }
}
