using Domain.Entities;
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

        //public DbSet<Employee> Employee { get; set; }

        //public DbSet<Customer> Customer { get; set; }

        //public DbSet<Distributor> Distributor { get; set; }

        //public DbSet<Domain.Entities.Color> Color { get; set; }

        //public DbSet<Capacity> Capacity { get; set; }

        //public DbSet<Category> Category { get; set; }

        //public DbSet<Specifications> Specifications { get; set; }

        //public DbSet<DetailSpecifications> DetailSpecifications { get; set; }

        //public DbSet<Product> Product { get; set; }

        //public DbSet<ProductSpecifications> ProductSpecifications { get; set; }

    }
}
