using System.Collections.Generic;

namespace RavenR.Infrastructure
{
  public class PaginatedResult<T>
  {
    public List<T> ItemsList { get; set; }
    public int PageIndex { get; set; }
    public int TotalPages { get; set; }
  }
}
