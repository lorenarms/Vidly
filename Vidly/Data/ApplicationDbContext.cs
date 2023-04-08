using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Vidly.Models;

namespace Vidly.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
			
		}

		

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<MembershipType> MembershipType { get; set; }
		public DbSet<Genre> Genre { get; set; }
		public DbSet<ApplicationUser> ApplicationUser { get; set; }
		public DbSet<IdentityRole> Roles { get; set; }
		public DbSet<IdentityUser> Users { get; set; }
		
	}
}