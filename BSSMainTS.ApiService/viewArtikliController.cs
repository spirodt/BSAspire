using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BSSMainTS.ApiService.Data;
using BSSMainTS.ApiService.Model;
using Microsoft.AspNetCore.OutputCaching;
using Google.Protobuf.WellKnownTypes;

namespace BSSMainTS.ApiService
{
    [Route("api/[controller]")]
    [ApiController]
    public class viewArtikliController : ControllerBase
    {
        private readonly BSSMainTSApiServiceContext _context;

        public viewArtikliController(BSSMainTSApiServiceContext context)
        {
            _context = context;
        }

        // GET: api/viewArtikli
        [HttpGet]
        [OutputCache(PolicyName = "viewArtikli")]
        [RateLimit("fixed")]
        public async Task<ActionResult<IEnumerable<viewArtikli>>> GetviewArtikli()
        {
            return await _context.viewArtikli.ToListAsync();
        }

    }
}
