using Microsoft.EntityFrameworkCore;
using SupplierAPI.Models;

namespace SupplierAPI.Contexts
{
    public class SupplierContext:DbContext
    {
        public SupplierContext(DbContextOptions opts) : base(opts)
        {

        }
        public DbSet<Supplier> suppliers { get; set; }
        public DbSet<Product> products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Supplier>().HasKey(es => new { es.Id, es.Email });

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 101, Name = "Ramu", Email = "Ramu@gmail.com", Phone = "1234567890"},
                new Supplier { Id = 102, Name = "Somu", Email = "Somu@gmail.com", Phone = "9876543210"}

                );
           

        }

    }
}
