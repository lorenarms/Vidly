using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using System.Security.Claims;
using Vidly.Data;
using Vidly.Models;


namespace Vidly.Controllers
{
	[Authorize(Roles = "Admin")]
	public class ApplicationRoles : Controller
	{
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly UserManager<IdentityUser> _userManager;

		private ApplicationDbContext _context;
		
		public ApplicationRoles(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)	
		{
			_roleManager = roleManager;
			_userManager = userManager;

			_context = context;

			
		}



		// List all roles created by user
		public IActionResult Index()
		{
			IDictionary<ApplicationUser, string> appUsers = new Dictionary<ApplicationUser, string>();
			var currUsers = _context.ApplicationUser;
			foreach (var cu in currUsers)
			{
				appUsers.Add(cu, cu.Role);
			}

			var roles = _roleManager.Roles;
			return View(roles);
		}

		[Route("/getusersandroles")]
		public IActionResult GetUsersAndRoles()
		{
			var usersAndRoles = _context.ApplicationUser;
			return View(usersAndRoles);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(IdentityRole model)
		{
			// avoid duplicate role
			if (!_roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
			{
				_roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
			}

			return RedirectToAction("Index");
		}
	}
}
