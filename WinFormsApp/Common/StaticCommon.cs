using Database;
using Microsoft.Extensions.Configuration;

namespace WinFormsApp.Common
{
    public static class StaticCommon
    {
        public static string ConnectionString
        {
            get
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                return configuration.GetConnectionString("SmartPhoneConnectionString");
            }
        }

        public static DatabaseAccess DatabaseAccess
        {
            // Set: ...
            get
            {
                return new DatabaseAccess(ConnectionString);
            }
        }
    }
}
