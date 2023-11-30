using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class UserRoleRepository : BaseRepository<UserRole>, IUserRoleRepository
    {
        #region CONST AND STATIC
        #endregion


        #region PROPERTIES

        protected override string _model { get; } = nameof(UserRole);

        protected override List<string> _fields { get; } = new List<string>()
        {
            "UserId",
            "RoleId",
        };

        protected override List<string> _seachers { get; } = new List<string>()
        {
            "UserId",
        };

        #endregion

        #region CONSTRUCTER

        public UserRoleRepository() { }

        #endregion


        #region FUNCTION


        #endregion
    }
}
