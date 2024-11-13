using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewArtikalInfo
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public string? AltSifra { get; set; }

    public string Naziv { get; set; } = null!;

    public decimal? PlanskaCena { get; set; }

    public decimal ProdaznaCena { get; set; }

    public string? Kratenka { get; set; }

    public decimal? Ddvprocent { get; set; }

    public decimal? ProdaznaCenaBezDdv { get; set; }

    public int TblDdvstavkaId { get; set; }

    public int TblEdinecniMerkiId { get; set; }
}
