 using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TowerOfBones.Models;

namespace TowerOfBones.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
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