using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Min18YearsIfAMember : ValidationAttribute
	{
		protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
		{
			var customer = (Customer) validationContext.ObjectInstance;

			if (customer.MembershipTypeId == MembershipType.Unknown ||
			    customer.MembershipTypeId == MembershipType.PayAsYouGo)
				return ValidationResult.Success;

			if (customer.Birthdate == null)
				return new ValidationResult("Birthdate is Required");

			var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

			return (age >= 18)
				? ValidationResult.Success
				: new ValidationResult("Customer must be 18 or older to sign-up for this membership type");
		}
	}
}
