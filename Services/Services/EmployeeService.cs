using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
using Services.Validators;
using System.Reflection;
using System.Transactions;

namespace Services.Services
{
    public class EmployeeService : IEmployeeService, IService
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

        [RequirePermission("Employee.View")]
        public async Task<(List<EmployeeDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _employeeRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<EmployeeDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Employee.View")]
        public async Task<EmployeeDto> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var employee = await _employeeRepo.GetDetailAsync(pId);

            var employeeDto = _mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        [RequirePermission("Employee.Create")]
        public async Task<bool> Create(EmployeeDto pCreate)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            EmployeeValidator validator = new EmployeeValidator(_employeeRepo, true);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            using (var transaction = new TransactionScope())
            {
                var resultAccount = await _authService.CreateAccount(new UserDto
                {
                    UserName = pCreate.InternalCode,
                    Password = pCreate.InternalCode
                });

                if (resultAccount > 0)
                {
                    pCreate.UserId = resultAccount;
                    Employee employee = _mapper.Map<Employee>(pCreate);
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
        }


        [RequirePermission("Employee.Update")]
        public async Task<bool> Update(EmployeeDto pUpdate)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            EmployeeValidator validator = new EmployeeValidator(_employeeRepo, false, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            Employee employee = _mapper.Map<Employee>(pUpdate);

            var result = await _employeeRepo.UpdateAsync(employee);

            return result > 0;
        }

        [RequirePermission("Employee.Delete")]
        public async Task<bool> Delete(int pId)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _employeeRepo.DeleteAsync(pId);

            return result;
        }
    }
}
