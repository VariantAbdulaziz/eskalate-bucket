using EntityCore.Data;
using EntityCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class TeamsController : ControllerBase
{
    private readonly ApiDbContext _context;
    public TeamsController(ApiDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Team>> Get()
    {
        return Ok(_context.Teams);
    }

    [HttpGet("{id}")]
    public ActionResult<Team> Get(int id)
    {
        var team = _context.Teams.Find(id);
        if(team is null)
            return NotFound();
            
        return Ok(team);
    }

    [HttpPost]
    public async Task<ActionResult<Team>> Post(Team team)
    {
        await _context.Teams.AddAsync(team);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Post), team);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Team updatedTeam)
    {
        var team =  _context.Teams.Find(id);
        if (team is null)
        {
            return NotFound();
        }
        team = updatedTeam;
        _context.Teams.Update(updatedTeam);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        var team = _context.Teams.Find(id);
        if (team is null)
        {
            return NotFound();
        }

        _context.Teams.Remove(team);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
