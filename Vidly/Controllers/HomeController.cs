using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;

namespace Vidly.Controllers
{
	[AllowAnonymous]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly UserManager<ApplicationUser> _userManager;
		private RoleManager<IdentityRole> _roleManager;
		private ApplicationDbContext _context;

        public HomeController(
	        UserManager<ApplicationUser> userManager,
	        ILogger<HomeController> logger, 
	        RoleManager<IdentityRole> roleManager,
	        ApplicationDbContext context)
		{
			_logger = logger;
			_userManager = userManager;
			_roleManager = roleManager;
            _context = context;
		}

		public async Task<IActionResult> Index()
        {
			var users = await _userManager.Users.ToListAsync();
			return View(users);
			//return View();

		}

		[HttpGet]
		public async Task<IActionResult> Edit(string Id)
		{
			
		}
		

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}