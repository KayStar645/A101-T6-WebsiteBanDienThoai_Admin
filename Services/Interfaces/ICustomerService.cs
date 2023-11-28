using Domain.DTOs;

namespace Services.Interfaces
{
    public interface ICustomerService
    {
        Task<(List<CustomerDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<CustomerDto> GetDetail(int pId);

        Task<bool> Update(CustomerDto customer);
    }
}
