using Dapper;
using Database.Common;
using Database.Interfaces;
using Domain.Entities;
using System.Data.SqlClient;

namespace Database.Repositories
{
    public class DetailSpecificationsRepository : BaseRepository<DetailSpecifications>, IDetailSpecificationsRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(DetailSpecifications);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "Name",
            "Description",
            "SpecificationsId",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "Name",
            "Description",
            "SpecificationsId",
        };

        #endregion

        #region CONSTRUCTER

        public DetailSpecificationsRepository() { }

        #endregion


        #region FUNCTION
        public virtual async Task<List<DetailSpecifications>> GetBySpecificationsIdAsync(int pSpecificationsId)
        {
            List<string> filter = new List<string>();
            filter.Add($"IsDeleted = 0");

            string query = $"select Id, {string.Join(", ", _fields)} " +
                           $"from {_model} " +
                           $"where {string.Join(" and ", filter)} and SpecificationsId = {pSpecificationsId}" +
                           $"order by Id;";

            using (var connection = new SqlConnection(DatabaseCommon.ConnectionString))
            {
                var result = await connection.QueryAsync<DetailSpecifications>(query).ConfigureAwait(false);

                return result.AsList();
            }
        }

        #endregion
    }
}
