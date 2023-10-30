using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<(List<EmployeeDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<EmployeeDto> GetDetail(int pId);

        Task<bool> Create(EmployeeDto pCreate);

        Task<bool> Update(EmployeeDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
