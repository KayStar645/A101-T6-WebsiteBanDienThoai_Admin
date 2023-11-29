using Domain.DTOs;

namespace Domain.ModelViews
{
    public class AuthVM
    {
        public int Id { get; set; }

        public string? UserName { get; set; }

        public string? Token { get; set; }

        public List<string> Permission {  get; set; }

        public EmployeeDto Employee { get; set; }
    }
}
