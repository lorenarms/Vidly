using Microsoft.AspNetCore.Mvc;

namespace Vidly.Controllers
{
	public class RentalController : Controller
	{
		public IActionResult New()
		{
			return View();
		}
	}
}
