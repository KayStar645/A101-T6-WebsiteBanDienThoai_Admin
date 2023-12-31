﻿using AutoMapper;
using Domain.DTOs;
using Domain.DTOs.More;
using Domain.Entities;
using Domain.ModelViews;

namespace Services.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<string, List<string>>().ConvertUsing<StringToListTypeConverter>();
            CreateMap<List<string>, string>().ConvertUsing<ListToStringTypeConverter>();

            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Distributor, DistributorDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Domain.Entities.Color, ColorDto>().ReverseMap();
            CreateMap<Capacity, CapacityDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<ProductParameters, ProductParametersDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<ProductPropertiesDto, ProductVM>().ReverseMap();
            CreateMap<DetailProductPropertiesDto, DetailProductVM>().ReverseMap();

            CreateMap<Specifications, SpecificationsDto>().ReverseMap();
            CreateMap<DetailSpecifications, DetailSpecificationsDto>().ReverseMap();
            CreateMap<ImportBill, ImportBillDto>().ReverseMap();
            CreateMap<DetailImport, DetailImportDto>().ReverseMap();

            CreateMap<Promotion, PromotionDto>().ReverseMap();
            CreateMap<PromotionProduct, PromotionProductDto>().ReverseMap();

            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<DetailOrder, DetailOrderDto>().ReverseMap();

            CreateMap<Role, RoleVM>().ReverseMap();

        }

        private class StringToListTypeConverter : ITypeConverter<string, List<string>>
        {
            public List<string> Convert(string source, List<string> destination, ResolutionContext context)
            {
                if (string.IsNullOrEmpty(source))
                {
                    return new List<string>();
                }

                return source.Split(',').ToList();
            }
        }

        private class ListToStringTypeConverter : ITypeConverter<List<string>, string>
        {
            public string Convert(List<string> source, string destination, ResolutionContext context)
            {
                if (source == null || source.Count == 0)
                {
                    return null;
                }

                return string.Join(",", source);
            }
        }
    }
}
