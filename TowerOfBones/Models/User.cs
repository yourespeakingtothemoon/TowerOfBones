using System.ComponentModel.DataAnnotations;

namespace TowerOfBones.Models
{
    public class User
    {
        [Key]
        [Required]
        private static int ID { get; set; }
        [Required(ErrorMessage = "You must have a username.")]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Your must have a password.")]
        [MaxLength(255)]
        [MinLength(8)]
        public string Password { get; set; }
        // there will probably need to be more things here like preferences and maybe stats or something

        public User() { }

    }
}
