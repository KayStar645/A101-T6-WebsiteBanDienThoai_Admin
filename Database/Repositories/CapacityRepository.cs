using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class CapacityRepository : BaseRepository<Capacity>, ICapacityRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Capacity);

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

        public CapacityRepository() { }

        #endregion


        #region FUNCTION


        #endregion
    }
}
