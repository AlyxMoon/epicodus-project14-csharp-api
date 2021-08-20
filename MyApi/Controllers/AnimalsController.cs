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
    public void Find ()
    {

    }

    [HttpGet("random")]
    public void GetRandom ()
    {

    }

    [HttpGet("{id}")]
    public void Get (int id)
    {

    }

    [HttpPost]
    public void Create ()
    {

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