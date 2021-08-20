using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using MyApi.Models;
using MyApi.Models.Database;

namespace MyApi.Controllers
{
  [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
  [ApiController]
  [Route("api/[controller]")]
  public class AnimalsController : Controller
  {
    private readonly DatabaseContext _db;

    public AnimalsController(
      DatabaseContext db
    )
    {
      _db = db;
    }

    [HttpGet]
    public List<Animal> Find ()
    {
      return _db.Animals.ToList();
    }

    [HttpGet("random")]
    public Animal GetRandom ()
    {
      int count = _db.Animals.Count();
      if (count == 0) return new Animal();

      Random random = new ();
      return _db.Animals.Skip(random.Next(0, count - 1)).Take(1).First();
    }

    [HttpGet("{id}")]
    public Animal Get (int id)
    {
      return _db.Animals.FirstOrDefault(item => item.AnimalId == id);
    }

    [HttpPost]
    public async Task<Animal> Create (Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return animal;
    }

    [HttpPut("{id}")]
    public async Task<Animal> Update (int id, Animal animal)
    {
      animal.AnimalId = id;

      _db.Entry(animal).State = EntityState.Modified;
      await _db.SaveChangesAsync();

      return animal;
    }

    [HttpPatch("{id}")]
    public async Task<Animal> Patch (int id, [FromBody] JsonPatchDocument<Animal> patch)
    {
      Animal animal = _db.Animals.FirstOrDefault(item => item.AnimalId == id);

      patch.ApplyTo(animal, ModelState);
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      await _db.SaveChangesAsync();

      return animal;
    }

    [HttpDelete("{id}")]
    public async Task<Animal> Delete (int id)
    {
      Animal animal = _db.Animals.FirstOrDefault(item => item.AnimalId == id);
      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return animal;
    }
  }
}