using Database.Common;

namespace Database.Entities
{
    public class Capacity : BaseEntity
    {
        public string? InternalCode { get; set; }

        public string? Name { get; set; }
    }
}
