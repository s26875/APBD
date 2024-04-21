namespace Zad_6;
// обрабатываeт запросы к вашему API

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;


[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AnimalsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/animals
    [HttpGet]
    public async Task<IActionResult> GetAnimals([FromQuery] string orderBy)
    {
        IQueryable<Animal> query = _context.Animals;

        switch (orderBy)
        {
            case "name":
                query = query.OrderBy(a => a.Name);
                break;
            case "description":
                query = query.OrderBy(a => a.Description);
                break;
            case "category":
                query = query.OrderBy(a => a.Category);
                break;
            case "area":
                query = query.OrderBy(a => a.Area);
                break;
            default:
                query = query.OrderBy(a => a.Name); // Default sorting
                break;
        }

        var animals = await query.ToListAsync();
        return Ok(animals);
    }
}
