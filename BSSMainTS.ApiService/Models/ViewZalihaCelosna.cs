using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewZalihaCelosna
{
    public int? TblArtikalId { get; set; }

    public string? Naziv { get; set; }

    public decimal ProdaznaCena { get; set; }

    public string? EdinecnaMerkaVlez { get; set; }

    public string? EdinecnaMerkaIzlez { get; set; }

    public decimal? IznosBezDdv { get; set; }

    public decimal? IznosDdv { get; set; }

    public decimal? IznosSoDdv { get; set; }

    public decimal? IzdadenaKolicina { get; set; }

    public decimal? KolicinaIzlez { get; set; }

    public decimal? KolicinaVlez { get; set; }

    public decimal? KolicinaZaliha { get; set; }

    public string? Partner { get; set; }

    public string? AltSifraArtikal { get; set; }

    public decimal? PreostanataKolicinaNaZaliha { get; set; }
}
