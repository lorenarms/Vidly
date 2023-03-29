using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.Models;

namespace Vidly.Controllers.API
{
	[Route("/api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private ApplicationDbContext _context;

		public CustomersController(ApplicationDbContext context)
		{
			_context = context;
		}


		// GET /api/customers
		[HttpGet]
		[Route("/api/customers")]
		public IEnumerable<Customer> GetCustomers()
		{
			return _context.Customers.ToList();
		}

		// GET /api/customer/1
		[HttpGet]
		[Route("/api/customer/{id}")]
		public Customer GetCustomer(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customer == null)
			{
				throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());
			}

			return customer;
		}

		// POST /api/customers
		[HttpPost]
		[Route("/api/customers")]
		public Customer CreateCustomer(Customer customer)
		{
			if (!ModelState.IsValid)
			{
				throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());
			}

			_context.Customers.Add(customer);
			_context.SaveChanges();

			return customer;
		}

		// PUT /api/customer/1
		[HttpPut]
		[Route("/api/customer/{id}")]
		public void UpdateCustomer(int id, Customer customer)
		{
			if (!ModelState.IsValid)
			{
				throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());
			}

			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

			customerInDb.Name = customer.Name;
			customerInDb.Birthdate = customer.Birthdate;
			customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
			customerInDb.MembershipTypeId = customer.MembershipTypeId;

			_context.SaveChanges();
		}

		// DELETE /api/customer/1
		[HttpDelete]
		[Route("/api/customers/1")]
		public void DeleteCustomer(int id)
		{
			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

			_context.Customers.Remove(customerInDb);
			_context.SaveChanges();

		}
	}
}
