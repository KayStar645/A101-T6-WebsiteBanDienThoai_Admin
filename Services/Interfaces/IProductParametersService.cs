using Domain.DTOs;

namespace Services.Interfaces
{
    public interface IProductParametersService
    {

        Task<(List<ProductParametersDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "");

        Task<bool> Create(ProductParametersDto pCreate);

        Task<bool> Delete(int pId);
    }
}
