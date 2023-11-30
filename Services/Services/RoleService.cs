using AutoMapper;
using Database.Interfaces;
using Domain.Entities;
using Domain.ModelViews;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
using System.Transactions;

namespace Services.Services
{
    public class RoleService : IRoleService, IService
    {
        private readonly IRoleRepository _roleRepo;
        private readonly IPermissionRepository _permissionRepo;
        private readonly IMapper _mapper;
        private readonly IUserRoleRepository _userRoleRepo;


        public RoleService(IRoleRepository roleRepo, IPermissionRepository permissionRepo, IMapper mapper, IUserRoleRepository userRoleRepo)
        {
            _roleRepo = roleRepo;
            _permissionRepo = permissionRepo;
            _mapper = mapper;
            _userRoleRepo = userRoleRepo;
        }

        [RequirePermission("Role.View")]
        public async Task<List<Role>> GetList()
        {
            if (CustomMiddleware.CheckPermission("Role.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var roles = await _roleRepo.GetAllAsync();

            return roles.list;
        }

        [RequirePermission("Role.View")]
        public async Task<RoleVM> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission("Role.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var role = await _roleRepo.GetDetailAsync(pId);

            var mapRole = _mapper.Map<RoleVM>(role);
            mapRole.PermissionsName = await _permissionRepo.GetByRoleId(pId);

            return mapRole;
        }

        [RequirePermission("Role.Create")]
        public async Task<RoleVM> Create(RoleVM pCreate)
        {
            if (CustomMiddleware.CheckPermission("Role.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
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
        public async Task<RoleVM> Update(RoleVM pUpdate)
        {
            //if (CustomMiddleware.CheckPermission("Role.Update") == false)
            //{
            //    throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            //}
            using (var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    var mapRole = _mapper.Map<Role>(pUpdate);

                    var result = await _roleRepo.UpdateAsync(mapRole);

                    var role = await GetDetail(pUpdate.Id);

                    if(pUpdate.PermissionsName != null)
                    {
                        var deletePermission = role.PermissionsName.Except(pUpdate.PermissionsName);
                        var addPermission = pUpdate.PermissionsName.Except(role.PermissionsName);

                        foreach(var del in deletePermission)
                        {
                            await _roleRepo.DeleteRolePer(pUpdate.Id, del);
                        }

                        foreach(var add in addPermission)
                        {
                            await _roleRepo.AddRolePer(pUpdate.Id, add);
                        }    
                    }    

                    transaction.Complete();
                    return pUpdate;
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
            if (CustomMiddleware.CheckPermission("Role.Assign") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var exists = await _userRoleRepo.AnyKeyValueAsync(new[] { 
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

        [RequirePermission("Role.Assign")]
        public async Task<RoleVM> RevokeRole(AssignRoleVM pRequest)
        {
            if (CustomMiddleware.CheckPermission("Role.Assign") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var exists = await _userRoleRepo.AnyKeyValueAsync(new[] {
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
