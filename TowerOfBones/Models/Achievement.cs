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

        public string? Image { get; set; }

        public Achievement(string name, string desc, string img)
        {
            Name = name;
            Description = desc;
            Image = img;

        }
    }
}
