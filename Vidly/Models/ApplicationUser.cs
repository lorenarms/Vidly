using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Vidly.Controllers;

namespace Vidly.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

        [StringLength(255)] 
        public string DrivingLicense { get; set; }

		public string Role { get; set; }
    }

	
}
