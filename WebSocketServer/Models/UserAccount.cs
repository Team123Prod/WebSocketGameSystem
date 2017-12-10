using System.ComponentModel.DataAnnotations;

namespace GameSystem.Models
{
    public class UserAccount
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
