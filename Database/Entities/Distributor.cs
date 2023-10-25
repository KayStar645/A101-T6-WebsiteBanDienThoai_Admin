using Database.Common;

namespace Database.Entities
{
    public class Distributor : BaseEntity
    {
        public string? InternalCode { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }
    }
}
