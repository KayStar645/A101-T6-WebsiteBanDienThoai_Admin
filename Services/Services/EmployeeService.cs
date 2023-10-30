using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using System.Transactions;

namespace Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper, IAuthService authService)
        {
            _employeeRepo = employeeRepository;
            _mapper = mapper;
            _authService = authService;
        }

        public async Task<(List<EmployeeDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _employeeRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<EmployeeDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<EmployeeDto> GetDetail(int pId)
        {
            var employee = await _employeeRepo.GetDetailAsync(pId);

            var employeeDto = _mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        public async Task<bool> Create(EmployeeDto pCreateEmployee)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    var resultAccount = await _authService.CreateAccount(new UserDto
                    {
                        UserName = pCreateEmployee.InternalCode,
                        Password = pCreateEmployee.InternalCode
                    });

                    if (resultAccount > 0)
                    {
                        pCreateEmployee.UserId = resultAccount;
                        Employee employee = _mapper.Map<Employee>(pCreateEmployee);
                        var resultEmployee = await _employeeRepo.AddAsync(employee);

                        if (resultEmployee > 0)
                        {
                            transaction.Complete();
                            return true;
                        }    
                    }

                    transaction.Dispose();
                    return false;
                }
                catch (Exception)
                {
                    transaction.Dispose();
                    return false;
                }
            }
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
