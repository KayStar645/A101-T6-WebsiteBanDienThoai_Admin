using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class DistributorRepository : BaseRepository<Distributor>, IDistributorRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Distributor);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Address",
            "Phone"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Address",
            "Phone"
        };

        #endregion

        #region CONSTRUCTER

        public DistributorRepository() { }

        #endregion


        #region FUNCTION


        #endregion


    }
}
