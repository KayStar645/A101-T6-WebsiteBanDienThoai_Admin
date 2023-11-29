namespace Domain.ModelViews
{
    public class RoleVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<string>? PermissionsName { get; set; }
    }
}
