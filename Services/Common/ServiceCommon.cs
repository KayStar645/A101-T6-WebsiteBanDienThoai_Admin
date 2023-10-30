using Domain.DTOs;

namespace Services.Common
{
    public class ServiceCommon
    {
        public static AuthRespone AuthRespone
        {
            get
            {
                return new AuthRespone()
                {
                    Id = LibrarySettings.Default.UserId,
                    UserName = LibrarySettings.Default.UserName,
                    Token = LibrarySettings.Default.Token,
                };
            }
        }
    }
}
