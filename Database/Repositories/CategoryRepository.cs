using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Category);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "InternalCode",
            "Name",
        };

        #endregion

        #region CONSTRUCTER

        public CategoryRepository() { }

        #endregion


        #region FUNCTION


        #endregion


    }
}
