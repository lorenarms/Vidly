using AutoMapper;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Maps
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Customer, CustomerDTO>();
			CreateMap<CustomerDTO, Customer>()
				.ForMember(c => c.Id, opt => opt.Ignore());

			CreateMap<Movie, MovieDTO>();
			CreateMap<MovieDTO, Movie>()
				.ForMember(m => m.Id, opt => opt.Ignore());
		}
	}
}
