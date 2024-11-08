using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BSSMainTS.ApiService.Data;
using BSSMainTS.ApiService.Model;

namespace BSSMainTS.ApiService
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtikalController : ControllerBase
    {
        private readonly BSSMainTSApiServiceContext _context;

        public ArtikalController(BSSMainTSApiServiceContext context)
        {
            _context = context;
        }

        // GET: api/Artikal
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tblArtikal>>> GettblArtikal()
        {
            return await _context.tblArtikal.ToListAsync();
        }

        // GET: api/Artikal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<tblArtikal>> GettblArtikal(int id)
        {
            var tblArtikal = await _context.tblArtikal.FindAsync(id);

            if (tblArtikal == null)
            {
                return NotFound();
            }

            return tblArtikal;
        }

        // PUT: api/Artikal/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PuttblArtikal(int id, tblArtikal tblArtikal)
        {
            if (id != tblArtikal.ID)
            {
                return BadRequest();
            }

            _context.Entry(tblArtikal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblArtikalExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Artikal
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<tblArtikal>> PosttblArtikal(tblArtikal tblArtikal)
        {
            _context.tblArtikal.Add(tblArtikal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GettblArtikal", new { id = tblArtikal.ID }, tblArtikal);
        }

        // DELETE: api/Artikal/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletetblArtikal(int id)
        {
            var tblArtikal = await _context.tblArtikal.FindAsync(id);
            if (tblArtikal == null)
            {
                return NotFound();
            }

            _context.tblArtikal.Remove(tblArtikal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool tblArtikalExists(int id)
        {
            return _context.tblArtikal.Any(e => e.ID == id);
        }
    }
}
