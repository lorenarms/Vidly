using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using UsersAndRolesTutorial.Data;
using UsersAndRolesTutorial.Models;

namespace UsersAndRolesTutorial.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly  ApplicationDbContext _context;

		public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
		{
			_context = context;
			_logger = logger;
		}

		public async Task <IActionResult> Index()
		{
			var model = await _context.Users
				.Include(x => x.UserRoles)
				.ThenInclude(x => x.Role)
				.ToListAsync();

			return View(model);
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