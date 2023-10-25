using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class SmartPhoneDbContext : DbContext
    {
        public SmartPhoneDbContext(DbContextOptions<SmartPhoneDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SmartPhoneDbContext).Assembly);
        }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Distributor> Distributor { get; set; }

    }
}
