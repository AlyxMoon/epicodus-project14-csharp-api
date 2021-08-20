using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyApi.Models.Database
{
  public class DatabaseContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Animal> Animals { get; set; }

    public DatabaseContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}