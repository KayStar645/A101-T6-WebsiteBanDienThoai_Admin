using Database;
using Database.Common;

namespace WinFormsApp.Services
{
    public static class StaticService
    {
        public static DatabaseAccess databaseAccess = new DatabaseAccess(DatabaseCommon.ConnectionString);
    }
}
