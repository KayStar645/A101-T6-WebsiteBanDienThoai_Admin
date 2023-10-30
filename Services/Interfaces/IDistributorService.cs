using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IDistributorService
    {
        Task<(List<DistributorDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<DistributorDto> GetDetail(int pId);

        Task<bool> Create(DistributorDto pCreate);

        Task<bool> Update(DistributorDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
