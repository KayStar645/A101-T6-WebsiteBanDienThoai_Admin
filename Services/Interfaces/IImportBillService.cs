using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IImportBillService
    {
        Task<string> RangeInternalCode();

        Task<(List<ImportBillDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pEmployeeId = null, int? pDistributorId = null);

        Task<ImportBillDto> GetDetail(int pId);

        Task<bool> Create(ImportBillDto pImportBill);
    }
}
