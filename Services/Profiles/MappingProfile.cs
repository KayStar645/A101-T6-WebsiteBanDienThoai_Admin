using AutoMapper;
using Domain.DTOs;
using Domain.Entities;

namespace Services.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Distributor, DistributorDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Domain.Entities.Color, ColorDto>().ReverseMap();
            CreateMap<Capacity, CapacityDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
