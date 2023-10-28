using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IDistributorService
    {
        Task<(List<DistributorDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<DistributorDto> GetDetail(int pId);

        Task<bool> Create(DistributorDto pCreateDistributor);

        Task<bool> Update(DistributorDto pUpdateDistributor);

        Task<bool> Delete(int pId);
    }
}
