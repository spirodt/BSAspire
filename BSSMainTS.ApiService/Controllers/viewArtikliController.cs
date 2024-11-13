using BSSMainTS.ApiService.Common;
using BSSMainTS.ApiService.Data;
using BSSMainTS.ApiService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;

namespace BSSMainTS.ApiService.Controllers
{
    [Route("api/Artikal")]
    [ApiController]
    public class viewArtikliController : ControllerBase
    {
        private readonly BSSMainTSApiServiceContext _context;

        public viewArtikliController(BSSMainTSApiServiceContext context)
        {
            _context = context;
        }

        // GET: api/viewArtikli
        [HttpGet("viewArtikli")]
        [OutputCache(PolicyName = "viewArtikli")]
        [RateLimit("fixed")]
        public async Task<ActionResult<IEnumerable<ViewArtikli>>> GetviewArtikli()
        {
            return await _context.ViewArtiklis.ToListAsync();
        }

    }
}
