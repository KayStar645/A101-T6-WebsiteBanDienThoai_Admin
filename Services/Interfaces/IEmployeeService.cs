using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<(List<EmployeeDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<EmployeeDto> GetDetail(int pId);

        Task<bool> Create(EmployeeDto pCreateEmployee);

        Task<bool> Update(EmployeeDto pUpdateEmployee);

        Task<bool> Delete(int pId);
    }
}
