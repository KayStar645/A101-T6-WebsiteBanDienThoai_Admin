using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Employee);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Sex",
            "Birthday",
            "Phone",
            "UserId"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Sex",
            "Birthday",
            "Phone",
            "UserId"
        };

        #endregion

        #region CONSTRUCTER

        public EmployeeRepository() { }


        #endregion
        public async Task<Employee> FindByInternalCodesync(string pInternalCode)
        {
            try
            {
                string query = $"SELECT Id, InternalCode, Name, Sex, Phone " +
                               $"FROM \"Employee\" " +
                               $"WHERE InternalCode = N'{pInternalCode}' and IsDeleted = 0";
                using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
                {
                    var result = await connection.QueryFirstOrDefaultAsync<Employee>(query).ConfigureAwait(false);
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }


        #region FUNCTION


        #endregion


    }
}
