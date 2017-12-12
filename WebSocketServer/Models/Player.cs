namespace GameSystem.Models
{
    public class Player
    {
        public string _login;
        public int idRoom { get; set; }

       public Player(string login)
       {
            _login = login;
       }
    }
}
