using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
	public class Movie
	{
		
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		[Required]
		public Genre Genre { get; set; }
		public byte GenreId { get; set; }

		[Display(Name = "Release Date")]
		public DateTime DateReleased { get; set; }
		public DateTime DateAdded { get; set; }

		[Display(Name = "Number in Stock")]
		public int NumberInStock { get; set; }


	}

	// /movies/random
}
