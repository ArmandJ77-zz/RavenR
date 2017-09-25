using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RavenR.Data;

namespace RavenR.Controllers
{
  public class ProductsController : BaseController
    {
      public ProductsController(AppDbContext context) : base(context)
      {
      }

    [HttpGet]
    public async Task<JsonResult> Get() => new JsonResult(await Context.Products.ToListAsync());
  }
}
