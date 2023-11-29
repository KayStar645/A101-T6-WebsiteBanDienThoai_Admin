﻿using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Domain.Identities;
using Services.Interfaces;
using Services.Interfaces.Common;

namespace Services.Services
{
    public class CustomerService : ICustomerService, IService
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepo = customerRepository;
            _mapper = mapper;
        }

        [RequirePermission("Customer.View")]
        public async Task<(List<CustomerDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _customerRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<CustomerDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Customer.View")]
        public async Task<CustomerDto> GetDetail(int pId)
        {
            var customer = await _customerRepo.GetDetailAsync(pId);

            var customerDto = _mapper.Map<CustomerDto>(customer);

            return customerDto;

        }
        public async Task<bool> Update(CustomerDto pUpdate)
        {

            var category = _mapper.Map<Customer>(pUpdate);

            var result = await _customerRepo.UpdateAsync(category);

            return result > 0;
        }

        // Không có tạo customer mà là khi mua hàng thì sẽ auto add vào
        // Không được sửa, xóa
    }
}
