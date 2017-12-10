using System;
using System.Collections.Generic;
using System.Linq;
using GameSystem.DAO;
using GameSystem.Models;

namespace GameSystem.DbMock
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
            users.Add(new UserAccount() { Id = 4, Email = "test@gmail.com", Login = "test", Password = "123" });
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

        //public bool CheckLoginExists(string login)
        //{
        //    return users.Any(account => string.Compare(account.Login, login) == 0);
        //}

        public UserAccount GetUserByLogin(string login)
        {
            return users.FirstOrDefault(account => string.Compare(account.Login, login) == 0);
        }
    }
}
