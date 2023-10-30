using Database.Interfaces;

namespace Database.Repositories
{
    public class ColorRepository : BaseRepository<Domain.Entities.Color>, IColorRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(Domain.Entities.Color);

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

        public ColorRepository() { }

        #endregion


        #region FUNCTION


        #endregion


    }
}
