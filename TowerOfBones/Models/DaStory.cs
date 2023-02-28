namespace TowerOfBones.Models
{
	public class DaStory
	{
		public enum Weather
			{
			SNOW,
			RAIN,
			CLOUDY,
			SUNNY,
			INSANEO_STYLE
		}

		public string Story { get; set; }
		//private Weather weather { get; set; }

		public DaStory(Weather weather)
		{
			switch(weather)
			{
				case Weather.SNOW:
					Story = "It was a cold and snowy day. The contemporary jazz classic Skating by Vince Guaraldi was playing on the loudspeakers. ";
					break;
				case Weather.CLOUDY:
					Story = "It was a cloudy day. The pop classic California Dreamin' by the Mommas and Poppas was playing on the loudspeakers. ";
					break;
				case Weather.RAIN:
					Story = "It was a rainy day. The Disney classic Little April Showers from the film Bambi was playing on the loudspeakers. ";
					break;
				case Weather.SUNNY:
					Story = "It was a bright and sunny day. The nerd rock classic Holiday by Weezer was playing on the loudspeakers. ";
					break;
				case Weather.INSANEO_STYLE:
					Story = "The day was totally insaneo style. ";
					//add thirty random characters to the story
					for (int i = 0; i < 30; i++)
					{
						Story += (char)('a' + new Random().Next(0, 26));
					}
					Story += " ";
					break;
				default:
					Story = "It was a day. ";
					break;

			}
			
			int random = new Random().Next(1, 6);
			switch (random)
			{
				case 1:
					Story += "Spooky, the skeleton with a penchant for fashion, found himself in the middle of an endless department store. He had lost his beloved golden monocle, a treasured possession he had acquired after defeating the evil wizard who had stolen it from him. Determined to get it back, Spooky donned his signature purple cape and top hat and began his quest, fighting through hordes of enemies and dodging traps at every turn.";
					break;
				case 2:
					Story += " Spooky, the dapper skeleton, found himself in a sprawling department store, searching for his lost golden monocle. As he made his way through the shelves and displays, he encountered all manner of strange and terrifying creatures, from animated mannequins to mischievous gremlins. But Spooky was undaunted, determined to retrieve his monocle at any cost.";
					break;
				case 3:
					Story += "Spooky, the well-dressed skeleton, found himself lost in a never-ending department store. He had been separated from his golden monocle, a precious artifact that had been in his family for generations, and was now on a mission to find it. Along the way, he battled through countless obstacles and fought off fierce enemies, his trusty purple cape and top hat billowing in the wind.";
					break;
				case 4:
					Story += "Spooky, the stylish skeleton, found himself trapped in a labyrinthine department store. His golden monocle, a prized possession he had inherited from his grandfather, had been stolen by a band of mischievous goblins, and Spooky was determined to get it back. As he navigated through the winding aisles and fought off the goblin hordes, Spooky's purple cape and top hat were a constant reminder of his unyielding determination.";
					break;
				case 5:
					Story += "Spooky, the fashion-forward skeleton, found himself deep in the heart of a vast department store. He had lost his golden monocle, a cherished family heirloom, and was determined to reclaim it at all costs. But the journey was perilous, as Spooky had to fight through a gauntlet of enemies and avoid deadly traps. With his trusty purple cape and top hat, Spooky fought on, his resolve unwavering even in the face of the greatest challenges.";
					break;
				default:
					//add 100 random characters of any kind
					for (int i = 0; i < 100; i++)
					{
						Story += (char)('a' + new Random().Next(0, 26));
					}
					break;
			}

			Story += " Join Spooky on his epic quest to retrieve his golden monocle, prove your skills in this exciting new game, put your gaming skills to the test and battle your way through an endless department store filled with danger, show off your skills as a gamer and take on the challenge - play now!";


		}

		
	}
}
