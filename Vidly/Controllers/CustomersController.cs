using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		private ApplicationDbContext _context;

		public CustomersController(ApplicationDbContext context)
		{
			_context = context;
		}
		
		public IActionResult Index()
		{
			
			var customers = _context.Customers.Include(c => c.MembershipType).ToList();

			return View(customers);
		}



		[Route("customers/{id}")]
		public IActionResult Details(int id)
		{
			var customer = _context.Customers.
				Include(c => c.MembershipType).
				SingleOrDefault(c => c.Id == id);
			
			if (customer == null)
			{
				return new NotFoundResult();
			}

			return View(customer);


		}
	}

	
}
