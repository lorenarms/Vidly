using System.Reflection.Metadata.Ecma335;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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
			
			var customers = _context.Customers.
				Include(c => c.MembershipType).ToList();

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
		[ValidateAntiForgeryToken]
		[Route("customers/save")]
		public IActionResult Save(Customer customer)
		{
			
			if (!ModelState.IsValid)
			{
				var viewModel = new CustomerFormViewModel
				{
					MembershipTypes = _context.MembershipType.ToList()
				};
				return View("CustomerForm", viewModel);
			}

			if (customer.Id == 0)
			{
				_context.Customers.Add(customer);
			}
			else
			{
				var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);

				// using mapper
				var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, Customer>());
				var mapper = config.CreateMapper();
				mapper.Map(customer, customerInDb);

				// conventional style
				//customerInDb.Name = customer.Name;
				//customerInDb.Birthdate = customer.Birthdate;
				//customerInDb.MembershipTypeId = customer.MembershipTypeId;
				//customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
				
			}

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

			var viewModel = new CustomerFormViewModel(customer)
			{
				MembershipTypes = _context.MembershipType.ToList()
			};
			return View("CustomerForm", viewModel);
		}
	}


	
}
