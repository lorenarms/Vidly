using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
	public class CustomersController : Controller
	{
		private IEnumerable<Customer> GetCustomers()
		{
			return new List<Customer>
			{
				new Customer {Id = 1, Name = "Angelina Dominguez"},
				new Customer {Id = 2, Name = "Lawrence Artl"}
			};
		}

		

		public IActionResult Index()
		{
			
			var customers = GetCustomers();

			return View(customers);
		}



		[Route("customers/{id}")]
		public IActionResult Details(int id)
		{
			var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
			if (customer == null)
			{
				return new NotFoundResult();
			}

			return View(customer);


		}
	}

	
}
