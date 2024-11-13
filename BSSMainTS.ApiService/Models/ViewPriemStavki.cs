using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewPriemStavki
{
    public int Id { get; set; }

    public int? PriemBroj { get; set; }

    public int TblArtikalId { get; set; }

    public int TblPriemId { get; set; }

    public string? Artikal { get; set; }

    public string? AltSifra { get; set; }

    public string? Edm { get; set; }

    public decimal Kolicina { get; set; }

    public decimal? Ddvstapka { get; set; }

    public decimal NabavnaCenaBezDdv { get; set; }

    public decimal NabavnaCenaSoDdv { get; set; }

    public decimal? Ddv { get; set; }

    public decimal IznosBezDdv { get; set; }

    public decimal IznosSoDdv { get; set; }

    public decimal? Rabat1 { get; set; }

    public decimal? Rabat2 { get; set; }

    public decimal? Rabat3 { get; set; }

    public decimal? ProdaznaCena { get; set; }

    public decimal ProdaznaVrednostSoDdv { get; set; }

    public decimal? Razlika { get; set; }

    public decimal PlanskaCena { get; set; }

    public decimal PlanskaVrednost { get; set; }

    public string? Sifra { get; set; }
}
