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

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
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

		[Route("customers/new")]
		public ActionResult New()
		{
			var membershipTypes = _context.MembershipType.ToList();
			var viewModel = new CustomerFormViewModel
			{
				MembershipTypes = membershipTypes
			};

			return View("CustomerForm", viewModel);
		}

		[HttpPost]
		[Route("customers/create")]
		public IActionResult Create(Customer customer)
		{
			_context.Customers.Add(customer);
			_context.SaveChanges();

			return RedirectToAction("Index", "Customers");
		}


		public IActionResult Edit(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
			if (customer == null)
			{
				return NotFound();
			}

			var viewModel = new CustomerFormViewModel
			{
				Customer = customer,
				MembershipTypes = _context.MembershipType.ToList()
			};
			return View("CustomerForm", viewModel);
		}
	}


	
}
