using System;
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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      Random random = new();

      string[] types = new string[] { "cat", "dog" };

      string[][] breeds = {
        new string[] {
          "munchkin", "shorthair", "siberian", "norweigan", "siamese"
        },
        new string[] {
          "husky", "german shepherd", "beagle", "poodle", "lab"
        }
      };

      string[] names = new string[] {
        "eric", "james", "bob", "whiskers", "henry", "frederick",
        "hailey", "claire", "poppy", "hal", "paws", "olive",
        "thor", "pancake", "yarin", "fig", "quin", "ames"
      };

      string [] descriptions = new string[] {
        "cute and affectionate",
        "curious about the world",
        "has a strong personality",
        "loves to run and play",
        "needs a quiet home",
      };

      Animal[] animals = new Animal[100];

      for (int i = 0; i < 100; i++) 
      {
        int typeIndex = random.Next(0, types.Length);
        animals[i] = new () 
        {
          AnimalId = i + 1,
          Type = types[typeIndex],
          Breed = breeds[typeIndex][random.Next(0, breeds[typeIndex].Length)],
          Name = names[random.Next(0, names.Length)],
          Description = descriptions[random.Next(0, descriptions.Length)],
          Age = random.Next(1, 20),
        };
      }

      builder.Entity<Animal>()
        .HasData(animals);
    }
  }
}