using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Services.Interfaces;
using System.DirectoryServices;

namespace Services.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepo = customerRepository;
            _mapper = mapper;
        }

        public async Task<(List<CustomerDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _customerRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<CustomerDto>>(result.list);

            return (list, result.totalCount);
        }

        public async Task<CustomerDto> GetDetail(int pId)
        {
            var customer = await _customerRepo.GetDetailAsync(pId);

            var customerDto = _mapper.Map<CustomerDto>(customer);

            return customerDto;

        }

        // Không có tạo customer mà là khi mua hàng thì sẽ auto add vào
        // Không được sửa, xóa
    }
}
