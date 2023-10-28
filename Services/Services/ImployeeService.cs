using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class ImployeeService : IImployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;
        private readonly IMapper _mapper;

        public ImployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepo = employeeRepository;
            _mapper = mapper;
        }

        public async Task<(List<EmployeeDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _employeeRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<EmployeeDto>>(result.list);

            return (list, result.totalCount);
        }

        public async Task<EmployeeDto> GetDetail(int pId)
        {
            var Employee = await _employeeRepo.GetDetailAsync(pId);

            var EmployeeDto = _mapper.Map<EmployeeDto>(Employee);

            return EmployeeDto;
        }

        public async Task<bool> Create(EmployeeDto pCreateEmployee)
        {
            Employee employee = _mapper.Map<Employee>(pCreateEmployee);

            var result = await _employeeRepo.AddAsync(employee);

            return result;
        }

        public async Task<bool> Update(EmployeeDto pUpdateEmployee)
        {
            Employee employee = _mapper.Map<Employee>(pUpdateEmployee);

            var result = await _employeeRepo.UpdateAsync(employee);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _employeeRepo.DeleteAsync(pId);

            return result;
        }
    }
}
