using Domain.DTOs;

namespace Services.Common
{
    public class OrderDetailIdComparer : IEqualityComparer<DetailOrderDto>
    {
        public bool Equals(DetailOrderDto x, DetailOrderDto y)
        {
            return x.ProductId == y.ProductId;
        }

        public int GetHashCode(DetailOrderDto obj)
        {
            return obj.ProductId.GetHashCode();
        }
    }
}
