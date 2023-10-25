using Database.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SmartPhoneDbContext>
    {
        public SmartPhoneDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SmartPhoneDbContext>();
            optionsBuilder.UseMySql(DatabaseCommon.ConnectionString,
                                    new MySqlServerVersion(new Version(8, 0, 31)),
                                    builder => builder.EnableRetryOnFailure());

            return new SmartPhoneDbContext(optionsBuilder.Options);
        }
    }
}
