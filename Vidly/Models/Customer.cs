using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }
		public bool IsSubscribedToNewsLetter { get; set; }
		public MembershipType MembershipType { get; set; }
		public byte MembershipTypeId { get; set; }

		[Display(Name = "Date of Birth")]
		public DateTime? Birthdate { get; set; }

	}
}