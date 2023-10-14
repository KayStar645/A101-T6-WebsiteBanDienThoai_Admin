using Database;
using WinFormsApp.Common;

namespace WinFormsApp.Services
{
    public static class StaticService
    {
        public static DatabaseAccess databaseAccess = new DatabaseAccess(StaticCommon.ConnectionString);
    }
}
