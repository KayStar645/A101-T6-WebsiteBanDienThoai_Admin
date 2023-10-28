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
        }
    }
}
