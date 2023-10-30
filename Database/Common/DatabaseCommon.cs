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

        public static string JwtSettings_Key
        {
            get
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                return configuration.GetSection("JwtSettings:Key").Value;
            }
        }

        public static string JwtSettings_Issuer
        {
            get
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                return configuration.GetSection("JwtSettings:Issuer").Value;
            }
        }

        public static string JwtSettings_Audience
        {
            get
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                return configuration.GetSection("JwtSettings:Audience").Value;
            }
        }

        public static string JwtSettings_DurationInMinutes
        {
            get
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                return configuration.GetSection("JwtSettings:DurationInMinutes").Value;
            }
        }
    }
}
