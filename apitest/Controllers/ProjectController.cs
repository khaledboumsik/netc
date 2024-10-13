using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProjectController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Create Project
    [HttpPost]
    public async Task<IActionResult> Create(CreateProjectDto dto)
    {
        var project = dto.ToProject();
        _context.Projects.Add(project);
        await _context.SaveChangesAsync();
        return Ok(project.ToReadUpdateProjectDto());
    }

    // Get Project by ID
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
        {
            return NotFound();
        }
        return Ok(project.ToReadUpdateProjectDto());
    }

    // Update Project
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CreateProjectDto dto)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
        {
            return NotFound();
        }

        // Update project fields
        project.About = dto.About;
        project.Degree = dto.Degree;
        project.Name = dto.Name;
        project.Price = dto.Price;
        project.Demo = dto.Demo;
        project.Picture = dto.Picture;

        await _context.SaveChangesAsync();
        return Ok(project.ToReadUpdateProjectDto());
    }

    // Delete Project
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var project = await _context.Projects.FindAsync(id);
        if (project == null)
        {
            return NotFound();
        }

        _context.Projects.Remove(project);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
