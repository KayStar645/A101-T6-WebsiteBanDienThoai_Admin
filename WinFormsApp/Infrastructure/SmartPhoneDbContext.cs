using Microsoft.EntityFrameworkCore;
using WinFormsApp.Infrastructure.Entities;

namespace WinFormsApp.Infrastructure
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

        public DbSet<Distributor> Distributors { get; set; }
    }
}
