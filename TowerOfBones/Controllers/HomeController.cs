 using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB;
using System.Diagnostics;
using TowerOfBones.Models;
using TowerOfBones.DAL;

using Microsoft.JSInterop;

namespace TowerOfBones.Controllers
{
	public class HomeController : Controller
	{



		public static User testUsr = new User("Test User", "1234", "test user to test features of the website", 2, 200, true, new List<Achievement>() { new Achievement("First Achievement", "You did something!", "1.png") }, new List<Achievement>() { new Achievement("Second Achievement", "You did something!", "1.png"),
			 new Achievement("Third Achievement", "You did something!", "1.png"),
			 new Achievement("Fourth Achievement", "You did something!", "1.png"),
			 new Achievement("Fifth Achievement", "You did something!", "1.png") });

		DataAccessLayer dali = new DataAccessLayer();
		




		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			//need to read up on how the MongoClient works in .NET before this works
		//	List<User> users = dali.GetUsers();
			//testUsr = users.First();
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Profile()
		{
			return View(testUsr);
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		public IActionResult Story()
		{
			WeatherNet.ClientSettings.SetApiKey("324b97110943279b777a4de1e5ea9f13");

			DaStory storytext;
			//https://api.open-meteo.com/v1/forecast?latitude=40.77&longitude=-111.89&hourly=rain,showers,snowfall,weathercode,cloudcover
			String wAPI;
			//int longi = LocationService.GetLongitude();
			//	int lat = LocationService.GetLatitude();
			GoogleApi.Entities.Maps.Geolocation.Request.GeolocationRequest req = new GoogleApi.Entities.Maps.Geolocation.Request.GeolocationRequest();
			req.Key = "AIzaSyBASJdBhRwVCwkBprmQ_BK7rgOzpakLoFo";
			double longi = GoogleApi.GoogleMaps.Geolocation.Query(req).Location.Longitude;
			double lat = GoogleApi.GoogleMaps.Geolocation.Query(req).Location.Latitude;
			/*	wAPI = "https://api.open-meteo.com/v1/forecast?latitude=" + lat + "&longitude=" + longi + "&hourly=weathercode";
				HttpClient httpClient;
				httpClient = new HttpClient();
				HttpResponseMessage response = httpClient.GetAsync(wAPI).Result;
				string json = response.Content.ReadAsStringAsync().Result;
				WeatherCodes weather 
			*/
			DaStory.Weather weat;
			var current = WeatherNet.Clients.CurrentWeather.GetByCoordinates(lat, longi);
			if(current.Success)
			{
				switch(current.Item.Title.ToLower())
				{
					case "clear":
						weat = DaStory.Weather.SUNNY;
						break;
					case "rain":
					case "drizzle":
						weat = DaStory.Weather.RAIN;
						break;
					case "snow":
						weat = DaStory.Weather.SNOW;
						break;
					case "clouds":
						weat = DaStory.Weather.CLOUDY;
						break;
					default:
						weat = DaStory.Weather.INSANEO_STYLE;
						break;
				}
			}
			else
			{
				weat = DaStory.Weather.INSANEO_STYLE;
			}
			storytext = new DaStory(weat);

			return View(storytext);

		}
		[HttpPost]
		//Card System: have this pop up on index page when not logged in, have sign up card there as well
		public IActionResult Login(User user)
		{
			// do the actual authentication
			// return to Login page if invalid
			return View("Index"); // return to home page if valid user
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
