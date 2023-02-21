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
        //[ForeignKey("AchievementID")] // i have no clue how foreign keys work in mvc. i think that this is correct but idk

        [Required]
        public int pfpID = 1;

		public string Bio { get; set; }

        public int HiLevel { get; set; } = 0;
		public int HiDebt { get; set; } = 0;



		//each earned achievement will be pushed to front so that the most recent achievement is at the top
		//maybe change this to a list later
		public virtual Achievement[] Earned { get; set; }

        //for big ach page only
        public virtual Achievement[] Locked { get; set; }
       //will create more robust acheivment system for this later
		// there will probably need to be more things here like preferences and maybe stats or something

		public User(int id, string username, string password) { 


			UserID = id;
			Username = username;
			Password = password;
			Earned = new Achievement[0];
			Locked = new Achievement[0];
            
			//Achievement = ach;
			//just need constructor so I can scaffold views

		}

		public string getPfpFile()
        {
			return "pfp" + pfpID + ".png";
		}


	}
}
