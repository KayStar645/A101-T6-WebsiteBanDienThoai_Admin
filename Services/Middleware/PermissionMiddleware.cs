using Domain.ModelViews;
using Services.Common;

namespace Services.Middleware
{
    public class PermissionMiddleware
    {
        public PermissionMiddleware()
        {
        }

        public bool CheckPermission()
        {
            AuthVM auth = ServiceCommon.AuthRespone;

            return true;
        }
    }

}
