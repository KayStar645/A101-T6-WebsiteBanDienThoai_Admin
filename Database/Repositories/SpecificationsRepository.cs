using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class SpecificationsRepository : BaseRepository<Specifications>, ISpecificationsRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Specifications);

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

        public SpecificationsRepository() { }

        #endregion


        #region FUNCTION


        #endregion
    }
}
