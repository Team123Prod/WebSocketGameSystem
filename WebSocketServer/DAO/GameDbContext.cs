using System.Data.Entity;
using GameSystem.Models;

namespace GameSystem.DAO
{
    public class GameDbContext: DbContext
    {
        public DbSet<UserAccount> UserAccount { get; set; }
        public GameDbContext() : base("DbFileConnection") //TODO: create DB, type path here
        {
        }
    }
}
