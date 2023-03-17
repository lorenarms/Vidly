using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		public IActionResult Random()
		{
			var movie = new Movie()
			{
				Name = "Shrek!"
			};

			return View(movie);
		}

		public IActionResult NotRandom()
		{
			var movie = new Movie()
			{
				Name = "Not Shrek!"
			};

			return View(movie);
		}
	}
}
