using Microsoft.Extensions.Configuration;

namespace Database.Common
{
    public class DatabaseCommon
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
