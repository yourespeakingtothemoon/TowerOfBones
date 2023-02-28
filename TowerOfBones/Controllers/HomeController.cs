 using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB;
using System.Diagnostics;
using TowerOfBones.Models;
using TowerOfBones.DAL;

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
