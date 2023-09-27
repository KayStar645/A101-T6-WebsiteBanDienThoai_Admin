using Database;
using WinFormsApp.Entities;
using WinFormsApp.Models;

namespace WinFormsApp.Repositories
{
    public class DistributorRepository : BaseRepository<DistributorModel>
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

        public DistributorRepository(DatabaseAccess databaseAccess) : base(databaseAccess)
        {
        }

        #endregion


        #region FUNCTION


        #endregion


    }
}
