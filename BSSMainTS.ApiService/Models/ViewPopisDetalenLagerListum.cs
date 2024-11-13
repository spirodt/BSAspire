using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewPopisDetalenLagerListum
{
    public int? TblArtikalId { get; set; }

    public string? AltSifraArtikal { get; set; }

    public string? Naziv { get; set; }

    public decimal? KolicinaVlez { get; set; }

    public decimal? KolicinaIzlez { get; set; }

    public decimal? PreostanataKolicina { get; set; }

    public string? Kratenka { get; set; }

    public decimal? ProsecnaNabavnaCena { get; set; }

    public decimal? ProdaznaCena { get; set; }
}
