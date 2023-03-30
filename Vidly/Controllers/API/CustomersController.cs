using System.Net;
using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.API
{
	[Route("/api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public CustomersController(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		
		// GET /api/customers
		[HttpGet]
		[Route("/api/customers")]
		public IEnumerable<CustomerDTO> GetCustomers()
		{
			return _context.Customers.ToList().Select(_mapper.Map<Customer, CustomerDTO>);
		}

		// GET /api/customer/1
		[HttpGet]
		[Route("/api/customer/{id}")]
		public IActionResult GetCustomer(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customer == null)
			{
				return NotFound();
			}

			return Ok(_mapper.Map<Customer, CustomerDTO>(customer));
		}

		// POST /api/customers
		[HttpPost]
		[Route("/api/customers")]
		public IActionResult CreateCustomer(CustomerDTO customerDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			var customer = _mapper.Map<CustomerDTO, Customer>(customerDto);
			_context.Customers.Add(customer);
			_context.SaveChanges();

			customerDto.Id = customer.Id;

			return Created(Request.Path.ToString() + "/" + customerDto.Id, customerDto);
		}

		// PUT /api/customer/1
		[HttpPut]
		[Route("/api/customer/{id}")]
		public IActionResult UpdateCustomer(int id, CustomerDTO customerDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				return NotFound();

			_mapper.Map(customerDto, customerInDb);

			_context.SaveChanges();

			return Accepted(Request.Path.ToString());
		}

		// DELETE /api/customer/1
		[HttpDelete]
		[Route("/api/customer/{id}")]
		public IActionResult DeleteCustomer(int id)
		{
			var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb == null)
				return NotFound();

			_context.Customers.Remove(customerInDb);
			_context.SaveChanges();

			return NoContent();

		}
	}
}
