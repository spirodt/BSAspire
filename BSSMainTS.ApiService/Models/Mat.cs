using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class Mat
{
    public string? Naziv { get; set; }

    public decimal? Kolicina { get; set; }

    public decimal? Iznos { get; set; }

    public decimal? ProdaznaCena { get; set; }

    public string? Sifra { get; set; }

    public int? NalogId { get; set; }

    public int? Artikal { get; set; }

    public int? Tip { get; set; }
}
