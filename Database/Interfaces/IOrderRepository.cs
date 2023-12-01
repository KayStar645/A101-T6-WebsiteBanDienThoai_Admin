using Domain.DTOs;
using Domain.Entities;

namespace Database.Interfaces
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        Task<bool> ChangeTypeOrderAsync(int pId, string type);

        Task<(List<OrderDto> list, int totalCount, int pageNumber)> GetAllPropertiesAsync(
                                        string? pKeyword = "", string? pSort = "Id", int? pPageNumber = 1,
                                        int? pPageSize = 10, int? pEmployeeId = null, int? pCustomerId = null);

        Task<OrderDto> GetDetailPropertiesAsync(int pId);

        Task UpdateQuantityProductWhenTransportOrder(int pOrderId, bool isTransport);
    }
}
