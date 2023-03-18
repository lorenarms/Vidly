using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				new Movie {Name = "Shrek!"},
				new Movie {Name = "Wall-e"}
			};
		}



		public ActionResult Index()
		{
			
			var movies = GetMovies();

			return View(movies);
		}



		// /movies/random
		public IActionResult Random()
		{
			var movie = new Movie()
			{
				Name = "Shrek!"
			};

			var customers = new List<Customer>
			{
				new Customer { Name = "Customer 1"},
				new Customer { Name = "Customer 2"}

			};

			var viewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customers = customers
			};
			
			return View(viewModel);
			//return Content("Hello World!");
			//return new EmptyResult();
			//return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"});
		}

		[Route("movies/released/{year}/{month:regex(\\d{{2}}):range(1,12)}")]
		public IActionResult ByReleaseDate(int year, int month)
		{
			return Content(year + "/" + month);
		}


		// /movies/edit?id=7
		
		public IActionResult Edit(int id)
		{
			return Content("id = " + id);
		}



		public ActionResult NotRandom()
		{
			var movie = new Movie()
			{
				Name = "Not Shrek!"
			};

			return View(movie);
		}
	}
}
