using Domain.ModelViews;

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
                };
            }
        }
    }
}
