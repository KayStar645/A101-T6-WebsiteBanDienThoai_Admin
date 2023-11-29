using Database.Interfaces;
using Domain.Entities;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using System.Reflection;

namespace Services.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepo;

        public PermissionService(IPermissionRepository permissionRepository) 
        {
            _permissionRepo = permissionRepository;
        }

        public List<string> GetRequiredPermissions()
        {
            var permissions = new List<string>();

            var assembly = Assembly.GetExecutingAssembly();

            var serviceTypes = assembly.GetTypes()
                .Where(type => typeof(IService).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);

            foreach (var serviceType in serviceTypes)
            {
                var methods = serviceType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Where(method => method.IsDefined(typeof(RequirePermissionAttribute), inherit: true));

                foreach (var method in methods)
                {
                    var authorizeAttributes = method.GetCustomAttributes<RequirePermissionAttribute>(true);
                    foreach (var authorizeAttribute in authorizeAttributes)
                    {
                        permissions.Add(authorizeAttribute.Permission);
                    }
                }
            }

            return permissions.Distinct().ToList();
        }

        public async Task<List<string>> Create(List<string> pPermissions)
        {
            try
            {
                foreach (var permission in pPermissions)
                {
                    var per = await _permissionRepo.FindByName(permission);

                    if (per.Count == 0)
                    {
                        await _permissionRepo.AddAsync(new Permission
                        {
                            Name = permission
                        });
                    }
                }

                var permissions = await _permissionRepo.GetAllAsync();

                return permissions.list.Select(x => x.Name).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
