using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WinFormsApp.Common;

namespace WinFormsApp
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SmartPhoneDbContext>
    {
        public SmartPhoneDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SmartPhoneDbContext>();
            optionsBuilder.UseSqlServer(StaticCommon.ConnectionString);

            return new SmartPhoneDbContext(optionsBuilder.Options);
        }
    }
}
