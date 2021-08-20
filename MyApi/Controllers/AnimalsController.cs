using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    public void GetRandom ()
    {

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
    public void Update ()
    {

    }

    [HttpPatch("{id}")]
    public void Patch ()
    {

    }

    [HttpDelete("{id}")]
    public void Delete ()
    {

    }
  }
}