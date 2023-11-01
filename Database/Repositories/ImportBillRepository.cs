using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class ImportBillRepository : BaseRepository<ImportBill>, IImportBillRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(ImportBill);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "ImportDate",
            "Price",
            "Type",
            "EmployeeId",
            "DistributorId"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Price",
            "Type",
            "EmployeeId",
            "DistributorId"
        };

        #endregion

        #region CONSTRUCTER

        public ImportBillRepository() { }


        #endregion


        #region FUNCTION


        #endregion
    }
}
