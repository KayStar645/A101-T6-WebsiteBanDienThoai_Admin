using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Role);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "Name",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "Name",
        };

        #endregion

        #region CONSTRUCTER

        public RoleRepository() { }

        #endregion


        #region FUNCTION
        public async Task<int> AssignRoles(UserRole userRole)
        {
            string query = $"INSERT INTO UserRole (UserId, RoleId, IsDeleted) " +
                           $"OUTPUT INSERTED.Id VALUES({userRole.UserId}, {userRole.RoleId}, 0)";

            using (var connect = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connect.ExecuteScalarAsync<int>(query).ConfigureAwait(false);
                return result;
            }    
        }

        public async Task<int> RevokeRole(UserRole userRole)
        {
            string query = $"DELETE FROM UserRole " +
                           $"OUTPUT DELETED.Id " +
                           $"WHERE UserId = {userRole.UserId} AND RoleId = {userRole.RoleId}";


            using (var connect = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connect.ExecuteScalarAsync<int>(query).ConfigureAwait(false);
                return result;
            }
        }

        public async Task DeleteRolePer(int pRoleId, string pPer)
        {
            var query = $"DELETE rp " +
                        $"OUTPUT DELETED.Id " +
                        $"FROM RolePermission as rp " +
                        $"LEFT JOIN Permission as p on p.Id = rp.PermissionId " +
                        $"WHERE RoleId = {pRoleId} and p.Name = N'{pPer}';";
            using(var connect = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connect.ExecuteScalarAsync(query).ConfigureAwait(false);
            }    
        }

        public async Task AddRolePer(int pRoleId, string pPer)
        {
            var query = $"INSERT INTO RolePermission (RoleId, PermissionId) " +
                        $"OUTPUT INSERTED.Id " +
                        $"SELECT {pRoleId}, p.Id " +
                        $"FROM Permission as p " +
                        $"WHERE p.Name = N'{pPer}';";
            using (var connect = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connect.ExecuteScalarAsync(query).ConfigureAwait(false);
            }
        }

        #endregion
    }
}
