using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.ViewModels
{
	public class CustomerFormViewModel
	{
		public IEnumerable<MembershipType> MembershipTypes { get; set; }
		//public Customer Customer { get; set; }

		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		public bool IsSubscribedToNewsLetter { get; set; }

		[Display(Name = "Membership Type")]
		public byte MembershipTypeId { get; set; }

		[Display(Name = "Date of Birth")]
		[Min18YearsIfAMember]
		public DateTime? Birthdate { get; set; }

		public CustomerFormViewModel()
		{
			Id = 0;
		}

		public CustomerFormViewModel(Customer customer)
		{
			Id = customer.Id;
			Name = customer.Name;
			IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
			MembershipTypeId = customer.MembershipTypeId;
			Birthdate = customer.Birthdate;
		}

		public string Title
		{
			get
			{
				return Id != 0 ? "Edit Customer" : "New Customer";
			}
		}

	}
}
