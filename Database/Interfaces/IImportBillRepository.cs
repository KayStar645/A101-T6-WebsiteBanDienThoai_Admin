using Domain.DTOs;
using Domain.Entities;

namespace Database.Interfaces
{
    public interface IImportBillRepository : IBaseRepository<ImportBill>
    {
        Task<(List<ImportBillDto> list, int totalCount, int pageNumber)> GetAllPropertiesAsync(
                                        string? pKeyword = "", string? pSort = "Id", int? pPageNumber = 1,
                                        int? pPageSize = 10, int? pEmployeeId = null, int? pDistributorId = null);

        Task<ImportBillDto> GetDetailPropertiesAsync(int pId);
    }
}
