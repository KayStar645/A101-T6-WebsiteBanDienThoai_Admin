using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Product);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Images",
            "Price",
            "CategoryId",
            "ColorId",
            "CapacityId"
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
            "Price",
            "CategoryId",
            "ColorId",
            "CapacityId"
        };

        #endregion

        #region CONSTRUCTER

        public ProductRepository() { }

        #endregion


        #region FUNCTION


        #endregion
    }
}
