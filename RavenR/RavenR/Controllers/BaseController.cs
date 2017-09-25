using Microsoft.AspNetCore.Mvc;
using RavenR.Data;

namespace RavenR.Controllers
{
  [Route("/api/[controller]")]
  public class BaseController : Controller
  {
    public AppDbContext Context;

    public BaseController(AppDbContext context)
    {
      Context = context;
    }
  }
}
