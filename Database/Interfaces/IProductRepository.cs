using Domain.DTOs;
using Domain.Entities;

namespace Database.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<(List<ProductPropertiesDto> list, int totalCount, int pageNumber)> GetAllPropertiesAsync(List<string> pFields = null, string? pKeyword = "", string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 10);
    }
}
