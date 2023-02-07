using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TowerOfBones.Models
{
    public class User
    {
        [Key]
        [Required]
        public static int UserID { get; set; }
        [Required(ErrorMessage = "You must have a username.")]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Your must have a password.")]
        [MaxLength(255)]
        [MinLength(8)]
        public string Password { get; set; }
        [ForeignKey("AchievementID")] // i have no clue how foreign keys work in mvc. i think that this is correct but idk
        public virtual Achievement[] Achievement { get; set; }
        // there will probably need to be more things here like preferences and maybe stats or something

        public User() { }

    }
}
