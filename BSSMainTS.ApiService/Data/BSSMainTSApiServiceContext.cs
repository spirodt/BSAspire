using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BSSMainTS.ApiService.Model;

namespace BSSMainTS.ApiService.Data
{
    public class BSSMainTSApiServiceContext : DbContext
    {
        public BSSMainTSApiServiceContext (DbContextOptions<BSSMainTSApiServiceContext> options)
            : base(options)
        {
        }

        public DbSet<BSSMainTS.ApiService.Model.tblArtikal> tblArtikal { get; set; } = default!;
        public DbSet<BSSMainTS.ApiService.Model.viewArtikli> viewArtikli { get; set; } = default!;
    }
}
