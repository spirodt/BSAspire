using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewSveUedno
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public string AltSifra { get; set; } = null!;

    public string? GrupaNaziv { get; set; }

    public string? PodGrupaNaziv { get; set; }

    public int Status { get; set; }

    public string Naziv { get; set; } = null!;

    public string? KlucniZborovi { get; set; }

    public decimal ProdaznaCena { get; set; }

    public string Normativ { get; set; } = null!;

    public int FirmaId { get; set; }

    public int? PodgrupaId { get; set; }

    public int? Ddv { get; set; }

    public decimal? Ddvstapka { get; set; }

    public string? Edm { get; set; }

    public string SearchString { get; set; } = null!;

    public string? Barkod { get; set; }

    public int? MomentalZaliha { get; set; }
}
