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

        #endregion
    }
}
