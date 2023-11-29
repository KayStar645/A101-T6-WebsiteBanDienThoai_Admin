using AutoMapper;
using Database.Interfaces;
using Domain.Entities;
using Domain.Identities;
using Domain.ModelViews;
using Services.Interfaces;
using System.Transactions;

namespace Services.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepo;
        private readonly IPermissionRepository _permissionRepo;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepo, IPermissionRepository permissionRepo, IMapper mapper)
        {
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            _mapper = mapper;
        }

        [RequirePermission("Role.View")]
        public async Task<List<Role>> GetList()
        {
            var roles = await _roleRepo.GetAllAsync();

            return roles.list;
        }

        [RequirePermission("Role.View")]
        public async Task<RoleVM> GetDetail(int pId)
        {
            var role = await _roleRepo.GetDetailAsync(pId);

            var mapRole = _mapper.Map<RoleVM>(role);
            mapRole.PermissionsName = await _permissionRepo.GetByRoleId(pId);

            return mapRole;
        }

        [RequirePermission("Role.Create")]
        public async Task<RoleVM> Create(RoleVM pCreate)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    var mapRole = _mapper.Map<Role>(pCreate);

                    var result = await _roleRepo.AddAsync(mapRole);

                    foreach (var permission in pCreate.PermissionsName)
                    {
                        await _roleRepo.AddRolePer(result, permission);
                    }

                    transaction.Complete();
                    return pCreate;
                }
                catch (Exception ex)
                {
                    transaction.Dispose();
                    throw;
                }
            }                   
        }

        [RequirePermission("Role.Update")]
        public async Task<RoleVM> Update(RoleVM pCreate)
        {
            using (var transaction = new TransactionScope())
            {
                try
                {
                    var mapRole = _mapper.Map<Role>(pCreate);

                    var result = await _roleRepo.UpdateAsync(mapRole);

                    var role = await GetDetail(result);

                    if(pCreate.PermissionsName != null)
                    {
                        var deletePermission = role.PermissionsName.Except(pCreate.PermissionsName);
                        var addPermission = pCreate.PermissionsName.Except(role.PermissionsName);

                        foreach(var del in deletePermission)
                        {
                            await _roleRepo.DeleteRolePer(result, del);
                        }

                        foreach(var add in addPermission)
                        {
                            await _roleRepo.AddRolePer(result, add);
                        }    
                    }    

                    transaction.Complete();
                    return pCreate;
                }
                catch (Exception ex)
                {
                    transaction.Dispose();
                    throw;
                }
            }
        }


        [RequirePermission("Role.Assign")]
        public async Task<RoleVM> AssignRoles(AssignRoleVM pRequest)
        {
            var exists = await _roleRepo.AnyKeyValueAsync(new[] { 
                ("RoleId", pRequest.RoleId.ToString()),
                ("UserId", pRequest.UserId.ToString())
            });
            if(exists == false)
            {
                await _roleRepo.AssignRoles(new UserRole
                {
                    UserId = pRequest.UserId,
                    RoleId = pRequest.RoleId
                });
            }  

            return await GetDetail(pRequest.RoleId);
        }

        public async Task<RoleVM> RevokeRole(AssignRoleVM pRequest)
        {
            var exists = await _roleRepo.AnyKeyValueAsync(new[] {
                ("RoleId", pRequest.RoleId.ToString()),
                ("UserId", pRequest.UserId.ToString())
            });
            if (exists == true)
            {
                await _roleRepo.RevokeRole(new UserRole
                {
                    UserId = pRequest.UserId,
                    RoleId = pRequest.RoleId
                });
            }

            return await GetDetail(pRequest.RoleId);
        }


    }
}
