using BSSMainTS.ApiService.Data;
using BSSMainTS.ApiService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BSSMainTS.ApiService.Controllers;
[ApiController]
public class CrudControllerBase<T> : ControllerBase where T : EntityBase
{
    protected readonly BSSMainTSApiServiceContext _context;

    public CrudControllerBase(BSSMainTSApiServiceContext context)
    {
        _context = context;
    }

    [HttpGet("getAll")]
    public virtual async Task<IActionResult> List()
    {
        var entities = await _context.Set<T>().ToListAsync();

        return Ok(entities);
    }

    [HttpGet("{id}")]
    public virtual async Task<IActionResult> Detail(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);

        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }

    [HttpPost("create")]
    public virtual async Task<IActionResult> Create(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();

        return CreatedAtAction("Detail", new { id = entity.Id }, entity);
    }

    [HttpPut("{id}")]
    public virtual async Task<IActionResult> Update(int id, T entity)
    {
        if (id != entity.Id)
        {
            return BadRequest();
        }

        if (!await EntityExists(id))
        {
            return NotFound();
        }

        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);

        if (entity == null)
        {
            return NotFound();
        }

        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private Task<bool> EntityExists(int id)
    {
        return _context.Set<T>().AnyAsync(e => e.Id == id);
    }
}
