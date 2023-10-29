using Database.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Database
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SmartPhoneDbContext>
    {
        public SmartPhoneDbContext CreateDbContext(string[] args)
        {
            //var optionsBuilder = new DbContextOptionsBuilder<SmartPhoneDbContext>();
            //optionsBuilder.UseMySql(DatabaseCommon.ConnectionString,
            //                        new SqlServerVersion(new Version(8, 0, 31)),
            //                        builder => builder.EnableRetryOnFailure());
            var optionsBuilder = new DbContextOptionsBuilder<SmartPhoneDbContext>();
            optionsBuilder.UseSqlServer(DatabaseCommon.ConnectionString);

            return new SmartPhoneDbContext(optionsBuilder.Options);
        }
    }
}
