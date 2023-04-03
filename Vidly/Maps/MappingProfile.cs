using AutoMapper;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.Maps
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Domain to DTO
			CreateMap<Customer, CustomerDTO>();
			CreateMap<Movie, MovieDTO>();
			CreateMap<MembershipType, MembershipTypeDTO>();
			CreateMap<Genre, GenreDTO>();


			// DTO to Domain
			CreateMap<CustomerDTO, Customer>()
				.ForMember(c => c.Id, opt => opt.Ignore());
			CreateMap<MovieDTO, Movie>()
				.ForMember(m => m.Id, opt => opt.Ignore());
		}
	}
}
