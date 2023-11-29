using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Permission);

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

        public PermissionRepository() { }

        #endregion


        #region FUNCTION
        public async Task<List<string>> FindByName(string pName)
        {
            string query = $"SELECT Name FROM Permission WHERE Name = N\'{pName}'";

            using(var connect = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connect.QueryAsync<string>(query).ConfigureAwait(false);

                return result.AsList();
            }    
        }

        public async Task<List<string>> GetByRoleId(int pRoleId)
        {
            string query = $"SELECT p.Name " +
                           $"FROM Permission as p " +
                           $"LEFT JOIN RolePermission as rp on rp.PermissionId = p.Id " +
                           $"WHERE rp.RoleId = {pRoleId}";
            using (var connect = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connect.QueryAsync<string>(query).ConfigureAwait(false);

                return result.AsList();
            }
        }

        #endregion
    }
}
