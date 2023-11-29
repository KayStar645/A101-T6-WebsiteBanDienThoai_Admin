using Domain.ModelViews;
using Services.Common;
using System.Reflection;

namespace Services.Middleware
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class RequirePermissionAttribute : Attribute
    {
        public string Permission { get; }

        public RequirePermissionAttribute(string permission)
        {
            Permission = permission;
        }
    }

    public static class CustomMiddleware
    {
        public static bool CheckPermission(string permissionAttribute)
        {
            if (permissionAttribute != null)
            {
                AuthVM auth = ServiceCommon.AuthRespone;
                return auth.Permission.Contains(permissionAttribute);
            }
            return true;
        }
    }
}
