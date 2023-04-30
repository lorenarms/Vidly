using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.API
{
	[Route("api/[controller]")]
	[ApiController]
	public class NewRentalsController : ControllerBase

	{
	
		private readonly ApplicationDbContext _context;

		public NewRentalsController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpPost]
		[Route("/api/newRental")]
		public IActionResult CreateNewRentals([FromForm] NewRentalDTO newRental)
		{
			var customer = _context.Customers.SingleOrDefault(
				c => c.Id == newRental.CustomerId);

			if (customer == null)
				return BadRequest("CustomerId is not valid.");

			// SELECT * FROM Movies WHERE id IN (1, 2, 3)
			var movies = _context.Movies.Where(
				m => newRental.MovieIds.Contains(m.Id)).ToList();

			if (movies.Count != newRental.MovieIds.Count)
				return BadRequest("One or more MovieId's are invalid.");

			foreach (var movie in movies)
			{
				if (movie.NumberAvailable == 0)
				{
					return BadRequest("Movie is not available.");
				}

				movie.NumberAvailable--;

				var rental = new Rental
				{
					Customer = customer,
					Movie = movie,
					DateRented = DateTime.Now
				};

				_context.Rental.Add(rental);
				
			}

			_context.SaveChanges();

			return Ok();
		}
	}
}
