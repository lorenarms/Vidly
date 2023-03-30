using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.DTOs
{
	public class MovieDTO
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		public byte GenreId { get; set; }

		[Required]
		public DateTime DateReleased { get; set; }

		public DateTime DateAdded { get; set; }

		[Range(1, 20)]
		public int NumberInStock { get; set; }
	}
}
