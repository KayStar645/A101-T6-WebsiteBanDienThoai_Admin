using Database.Interfaces;
using Domain.Entities;

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


        #endregion
    }
}
