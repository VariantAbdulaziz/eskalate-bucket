using EntityCore.Data;
using EntityCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class DriverMediasController : ControllerBase
{
    private readonly ApiDbContext _context;
    public DriverMediasController(ApiDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult<IEnumerable<DriverMedia>> Get()
    {
        return Ok(_context.DriverMedias);
    }

    [HttpGet("{id}")]
    public ActionResult<DriverMedia> Get(int id)
    {
        var driverMedia = _context.DriverMedias.Find(id);
        if(driverMedia is null)
            return NotFound();
            
        return Ok(driverMedia);
    }

    [HttpPost]
    public async Task<ActionResult<DriverMedia>> Post(DriverMedia DriverMedia)
    {
        await _context.DriverMedias.AddAsync(DriverMedia);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Post), DriverMedia);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, DriverMedia updatedDriverMedia)
    {
        var driverMedia =  _context.DriverMedias.Find(id);
        if (driverMedia is null)
        {
            return NotFound();
        }
        driverMedia = updatedDriverMedia;
        _context.DriverMedias.Update(updatedDriverMedia);
        await _context.SaveChangesAsync();
        return NoContent();
    }


    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var driverMedia = _context.DriverMedias.Find(id);
        if (driverMedia is null)
        {
            return NotFound();
        }

        _context.DriverMedias.Remove(driverMedia);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
