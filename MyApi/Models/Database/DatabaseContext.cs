using Microsoft.EntityFrameworkCore;

namespace MyApi.Models.Database
{
  public class DatabaseContext : DbContext
  {
    public DatabaseContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}