using GameServer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.DAO
{
    public class GameDbContext: DbContext
    {
        public DbSet<UserAccount> UserAccount { get; set; }
        public GameDbContext() : base("DbFileConnection") //TODO: create DB, type path here
        {
        }
    }
}
