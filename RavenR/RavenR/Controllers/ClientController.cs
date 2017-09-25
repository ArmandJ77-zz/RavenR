using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RavenR.Data;
using RavenR.Infrastructure;
using RavenR.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace RavenR.Controllers
{
  public class ClientController : BaseController
  {
    public ClientController(AppDbContext context) : base(context)
    {
    }

    [HttpGet]
    public async Task<JsonResult> Get() => new JsonResult(await Context.Clients.ToListAsync());

    [HttpGet]
    [Route("/api/[controller]/GetPaginated")]
    public async Task<JsonResult> GetPaginated(int? page, int pageSize) => new JsonResult(await PaginatedList<Client>.CreateAsync(Context.Clients.AsNoTracking(), page ?? 1, pageSize));

    [HttpPost]
    public async Task<JsonResult> Create([FromBody] Client clientDto)
    {
      try
      {
        await Context.Clients.AddAsync(clientDto);
        await Context.SaveChangesAsync();
        return new JsonResult(new { message = "Saved" });

      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return new JsonResult(new { message = "Failed" });
      }
    }

    [HttpDelete]
    public async Task<JsonResult> Delete(int? Id)
    {
      if (Id == null)
        return new JsonResult(NotFound());

      var client = await Context.Clients
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == Id);

      if (client == null)
        return new JsonResult(NotFound());

      try
      {
        Context.Clients.Remove(client);
        await Context.SaveChangesAsync();
        return new JsonResult(Ok());
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
        return new JsonResult(HttpStatusCode.InternalServerError);
      }
    }
  }
}
