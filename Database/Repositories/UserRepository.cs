using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(User);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "UserName",
            "Password",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "UserName",
            "Password",
        };

        #endregion

        #region CONSTRUCTER

        public UserRepository() { }

        #endregion


        #region FUNCTION
        public async Task<User> FindByNameAsync(string pUserName)
        {
            try
            {
                string query = $"SELECT Id, UserName, Password " +
                               $"FROM \"User\" " +
                               $"WHERE UserName = N'{pUserName}' and IsDeleted = 0";
                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var result = await connection.QueryFirstOrDefaultAsync<User>(query).ConfigureAwait(false);
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<string>> GetPermissionsByUserAsync(string pUserName)
        {
            string query = $"SELECT p.Name " +
                           $"FROM [User] as u " +
                           $"LEFT JOIN UserRole as ur on  ur.UserId = u.Id " +
                           $"LEFT JOIN RolePermission as rp on rp.RoleId = ur.RoleId " +
                           $"LEFT JOIN Permission as p on p.Id = rp.PermissionId " +
                           $"WHERE UserName = N'{pUserName}'";
            using (var connect = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connect.QueryAsync<string>(query).ConfigureAwait(false);
                return result.AsList();
            }
        }

        public async Task<List<string>> GetRoleByUserName(string pUserName)
        {
            string query = $"SELECT r.Name " +
                           $"FROM Role as r " +
                           $"LEFT JOIN UserRole as ur on ur.RoleId = r.Id " +
                           $"LEFT JOIN [User] as u on u.Id = ur.UserId " +
                           $"WHERE u.UserName = N'{pUserName}'";
            using(var connect = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connect.QueryAsync<string>(query).ConfigureAwait(false);
                
                return result.AsList();
            }    
        }

        #endregion
    }
}
