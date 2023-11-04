using Domain.DTOs;

namespace Domain.ModelViews
{
    public class DetailProductVM
    {
        public int Id { get; set; }

        public string? InternalCode { get; set; }

        public string? Name { get; set; }

        public List<string>? Images { get; set; }

        public int? Quantity { get; set; }

        public long? Price { get; set; }

        public int? CategoryId { get; set; }

        public string? CategoryName { get; set; }

        public string? CategoryInternalCode { get; set; }

        public int? ColorId { get; set; }

        public string? ColorInternalCode { get; set; }

        public string? ColorName { get; set; }

        public int? CapacityId { get; set; }

        public string? CapacityName { get; set; }

        public List<SpecificationsDto>? SpecificationsDtos { get; set; }
    }
}
