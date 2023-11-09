using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using Services.Validators;


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

        public async Task<bool> Create(EmployeeDto pCreate)
        {
			try
			{
				EmployeeValidator validator = new EmployeeValidator(_employeeRepo, true);
				var validationResult = await validator.ValidateAsync(pCreate);

				if (validationResult.IsValid == false)
				{
					var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
					throw new Exception(errorMessages);
				}

				Employee employee = _mapper.Map<Employee>(pCreate);

				var result = await _employeeRepo.AddAsync(employee);

				return result > 0;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


        public async Task<bool> Update(EmployeeDto pUpdate)
        {
			try
			{
				EmployeeValidator validator = new EmployeeValidator(_employeeRepo, false, pUpdate.Id);
				var validationResult = await validator.ValidateAsync(pUpdate);

				if (validationResult.IsValid == false)
				{
					var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
					throw new Exception(errorMessages);
				}

				Employee employee = _mapper.Map<Employee>(pUpdate);

				var result = await _employeeRepo.UpdateAsync(employee);

				return result;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        public async Task<bool> Delete(int pId)
        {
            var result = await _employeeRepo.DeleteAsync(pId);

            return result;
        }
    }
}
