using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewFakturiStavki
{
    public int Id { get; set; }

    public int TblFakturaId { get; set; }

    public int? Broj { get; set; }

    public int TblArtikalId { get; set; }

    public DateOnly? Datum { get; set; }

    public string? Sifra { get; set; }

    public string? AltSifa { get; set; }

    public string? Artikal { get; set; }

    public decimal? ProdaznaCena { get; set; }

    public decimal? Ddv { get; set; }

    public string? Edm { get; set; }

    public decimal Kolicina { get; set; }

    public decimal? Ddviznos { get; set; }

    public decimal? IznosBezDdv { get; set; }

    public decimal Iznos { get; set; }

    public decimal? Rabat3 { get; set; }

    public decimal? Rabat2 { get; set; }

    public decimal? Rabat1 { get; set; }

    public decimal? ProdaznaCenaSoDdvirabat { get; set; }

    public decimal? ProdaznaCenaBezDdvirabat { get; set; }

    public string? Barkod { get; set; }
}
