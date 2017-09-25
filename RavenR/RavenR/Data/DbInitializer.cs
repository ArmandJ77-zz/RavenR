using RavenR.Data.Seed;
using System.Linq;

namespace RavenR.Data
{
  public class DbInitializer
    {
      public static void Initialize(AppDbContext context)
      {
        context.Database.EnsureCreated();

        if (!context.Clients.Any())
          ClientSeed.Clients.ForEach(x => context.Clients.Add(x));

        if (!context.Products.Any())
          ProductSeed.Product.ForEach(x => context.Products.Add(x));

        context.SaveChanges();
      }
  }
}
