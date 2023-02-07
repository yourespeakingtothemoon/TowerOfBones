using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TowerOfBones.Models
{
    public class Highscore
    {
        [Key]
        [Required]
        public static int HighscoreID { get; set; }
        [Required]
        public int Score { get; set; }
        [ForeignKey("UserID")] // dont know how to do these so this will probably have to change
        public virtual User[] User { get; set; }
    }
}
