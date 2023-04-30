using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vidly.Data;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Controllers.API
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{
		private ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public MoviesController(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}



		// GET /api/movies
		[HttpGet]
		[Route("/api/movies")]
		public IActionResult GetMovies()
		{
			var movies = _context.
				Movies.
				Include(m => m.Genre).
				Where(m => m.NumberAvailable > 0).
				ToList().
				Select(_mapper.Map<Movie, MovieDTO>);

			return Ok(movies);
		}


		// GET /api/movie/{id}
		[HttpGet]
		[Route("/api/movie/{id}")]
		public IActionResult GetMovie(int id)
		{
			var movie = _context.Movies.FirstOrDefault(x => x.Id == id);

			if (movie == null)
			{
				return NotFound();
			}

			return Ok(_mapper.Map<Movie, MovieDTO>(movie));
		}


		// POST /api/movies
		[HttpPost]
		[Route("/api/movies")]
		public IActionResult AddMovie(MovieDTO movieDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest();
			}

			var movie = _mapper.Map<MovieDTO, Movie>(movieDto);
			_context.Movies.Add(movie);
			_context.SaveChanges();

			movieDto.Id = movie.Id;

			return Created(Request.Path + "/" + movieDto.Id, movieDto);
		}


		// PUT /api/movie{id}
		[HttpPut]
		[Route("/api/movie/{id}")]
		public IActionResult UpdateMovie(int id, MovieDTO movieDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();
			

			var movieInDb = _context.Movies.FirstOrDefault(m => m.Id == id);

			if (movieInDb == null)
				return NotFound();

			_mapper.Map(movieDto, movieInDb);
			_context.SaveChanges();
			return Accepted(Request.Path.ToString());
		}


		// DELETE /api/movie/{id}
		[HttpDelete]
		[Route("/api/movie/{id}")]
		// [Authorize(Roles = "Admin")]
		public IActionResult DeleteMovie(int id)
		{
			var movieInDb = _context.Movies.FirstOrDefault(m => m.Id == id);

			if (movieInDb == null)
				return NotFound();

			_context.Movies.Remove(movieInDb);
			_context.SaveChanges();

			return NoContent();
		}
	}





}
