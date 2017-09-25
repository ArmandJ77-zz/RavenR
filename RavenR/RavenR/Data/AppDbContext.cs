using Microsoft.EntityFrameworkCore;
using RavenR.Models;

namespace RavenR.Data
{
    public class AppDbContext : DbContext
  {
      public DbSet<Client> Clients { get; set; }
      public DbSet<Product> Products { get; set; }
      public DbSet<Sale> Sales { get; set; }

      public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
      {
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
        modelBuilder.Entity<Client>().ToTable("Clients");
        modelBuilder.Entity<Product>().ToTable("Products");
        modelBuilder.Entity<Sale>().ToTable("Sales");
      }
  }
}
