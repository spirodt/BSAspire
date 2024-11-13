using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewArtikliVoSmetkaKasabezZaokruzuenje
{
    public int? ArtikalId { get; set; }

    public string? Sifra { get; set; }

    public string? Sifra2 { get; set; }

    public string? Naziv { get; set; }

    public decimal? Kolicina { get; set; }

    public decimal Rabat { get; set; }

    public decimal? ProdaznaCena { get; set; }

    public decimal? CenaSoRabatIddv { get; set; }

    public decimal? CenaBezDdv { get; set; }

    public decimal? Ddvprocent { get; set; }

    public decimal? PresmetanDdv { get; set; }

    public decimal? Iznos { get; set; }

    public decimal? IznosBezDdv { get; set; }

    public int NalogId { get; set; }

    public int Tip { get; set; }

    public string? Zabeleska { get; set; }

    public int? SmetkaId { get; set; }

    public int? Danok { get; set; }

    public bool? MkProizvod { get; set; }
}
