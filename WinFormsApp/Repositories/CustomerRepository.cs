using Database;
using Database.Entities;
using WinFormsApp.Models;

namespace WinFormsApp.Repositories
{
    public class CustomerRepository : BaseRepository<CustomerModel>
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Customer);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Phone",
            "Name",
            "Address",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Phone",
            "Name",
            "Address",
        };

        #endregion

        #region CONSTRUCTER

        public CustomerRepository(DatabaseAccess databaseAccess) : base(databaseAccess)
        {
        }

        #endregion


        #region FUNCTION


        #endregion


    }
}
