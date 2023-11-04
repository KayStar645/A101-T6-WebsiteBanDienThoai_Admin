using Domain.DTOs.More;
using Domain.Entities;

namespace Database.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<(List<ProductPropertiesDto> list, int totalCount, int pageNumber)> GetAllPropertiesAsync(string? pKeyword = "", string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 10, int? CategoryId = null);

        Task<DetailProductPropertiesDto> GetDetailPropertiesAsync(int pId);

        Task<bool> IncreasingNumberAsync(int pProductId, int pNumber);
    }
}
