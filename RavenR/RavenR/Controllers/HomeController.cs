using Microsoft.AspNetCore.Mvc;

namespace RavenR.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
