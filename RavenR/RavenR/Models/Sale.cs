using System;

namespace RavenR.Models
{
  public class Sale
    {
      public int Id { get; set; }
      public int ClientId { get; set; }
      public int ProductId { get; set; }
      public int Qty { get; set; }
      public DateTime PurchasedDate { get; set; }

      public Client Client { get; set; }
      public Product Products { get; set; }
  }
}
