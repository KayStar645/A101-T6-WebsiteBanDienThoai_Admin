using Domain.DTOs;
using Domain.ViewModels;

namespace Services.Interfaces
{
    public interface IProductService
    {
        Task<(List<ProductVM> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<ProductDto> GetDetail(int pId);

        Task<bool> Create(ProductDto pCreate);

        Task<bool> Update(ProductDto pUpdate);

        Task<bool> Delete(int pId);
    }
}
