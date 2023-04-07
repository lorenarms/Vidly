using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Vidly.Controllers
{
	[Authorize]
	public class ApplicationRoles : Controller
	{
		private readonly RoleManager<IdentityRole> _roleManager;

		public ApplicationRoles(RoleManager<IdentityRole> roleManager)	
		{
			_roleManager = roleManager;
		}

		// List all roles created by user
		public IActionResult Index()
		{
			var roles = _roleManager.Roles;
			return View(roles);
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
