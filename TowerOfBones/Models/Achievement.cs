using System.ComponentModel.DataAnnotations;

namespace TowerOfBones.Models
{
    public class Achievement
    {
        [Key]
        [Required]
        public static int AchievementID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public Achievement() { }
    }
}
