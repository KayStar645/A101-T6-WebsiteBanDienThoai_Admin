namespace Database.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
