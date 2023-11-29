using Domain.DTOs;
using Domain.ModelViews;
using Newtonsoft.Json;

namespace Services.Common
{
    public class ServiceCommon
    {
        public static AuthVM AuthRespone
        {
            get
            {
                return new AuthVM()
                {
                    Id = LibrarySettings.Default.UserId,
                    UserName = LibrarySettings.Default.UserName,
                    Token = LibrarySettings.Default.Token,
                    Permission = LibrarySettings.Default.Permission.Split(',').ToList(),
                    Employee = JsonConvert.DeserializeObject<EmployeeDto>(LibrarySettings.Default.Employee)
                };
            }
        }
    }
}
