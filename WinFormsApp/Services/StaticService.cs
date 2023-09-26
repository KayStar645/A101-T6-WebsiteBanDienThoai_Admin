using Database;

namespace WinFormsApp.Services
{
    public static class StaticService
    {
        public static DatabaseAccess databaseAccess = new DatabaseAccess("Data Source=THUAN;Initial Catalog=DB_SmartPhone;Integrated Security=True;TrustServerCertificate=True;");
    }
}
