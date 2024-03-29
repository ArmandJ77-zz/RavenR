using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavenR.Infrastructure
{
  public class PaginatedList<T> : List<T>
  {
    public int PageIndex { get; }
    public int TotalPages { get; }

    public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
    {
      PageIndex = pageIndex;
      TotalPages = (int)Math.Ceiling(count / (double)pageSize);

      this.AddRange(items);
    }

    public bool HasPreviousPage => (PageIndex > 1);

    public bool HasNextPage => (PageIndex < TotalPages);

    public static async Task<PaginatedResult<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
    {
      var count = await source.CountAsync();
      var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();
      var bar = new PaginatedList<T>(items, count, pageIndex, pageSize);

      var foo = new PaginatedResult<T>
      {
        PageIndex = bar.PageIndex,
        ItemsList = items,
        TotalPages = bar.TotalPages

      };
      return foo;
    }
  }
}
