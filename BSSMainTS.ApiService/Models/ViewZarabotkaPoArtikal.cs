using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewZarabotkaPoArtikal
{
    public int? ArtikalId { get; set; }

    public string? Sifra { get; set; }

    public string? Artikal { get; set; }

    public decimal? NabavenaKolicina { get; set; }

    public decimal? IznosNabavena { get; set; }

    public decimal? ProsecnaNabavnaCena { get; set; }

    public decimal ProdaznaCena { get; set; }

    public decimal? ProdadenaKolicina { get; set; }

    public decimal? ProsecnaNabavnaCenaBezDdv { get; set; }

    public decimal? IznosOdProdazba { get; set; }

    public decimal? RealnaCena { get; set; }

    public decimal? FiskalNa { get; set; }

    public decimal? Zarabotka { get; set; }

    public string? Partner { get; set; }

    public decimal VrednostNaZaliha { get; set; }

    public decimal VrednostNaZalihaBezDdv { get; set; }

    public decimal KolicinaNaZaliha { get; set; }
}
