using EntityCore.Data;
using EntityCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class DriversController : ControllerBase
{
    private readonly ApiDbContext _context;
    public DriversController(ApiDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Driver>> Get()
    {
        return Ok(_context.Drivers);
    }

    [HttpGet("{id}")]
    public ActionResult<Driver> Get(int id)
    {
        var driver = _context.Drivers.Find(id);
        if(driver is null)
            return NotFound();
            
        return Ok(driver);
    }

    [HttpPost]
    public async Task<ActionResult<Driver>> Post(Driver driver)
    {
        await _context.Drivers.AddAsync(driver);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Post), driver);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Driver updatedDriver)
    {
        var driver =  _context.Drivers.Find(id);
        if (driver is null)
        {
            return NotFound();
        }
        driver = updatedDriver;
        _context.Drivers.Update(updatedDriver);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var driver = _context.Drivers.Find(id);
        if (driver is null)
        {
            return NotFound();
        }

        _context.Drivers.Remove(driver);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
