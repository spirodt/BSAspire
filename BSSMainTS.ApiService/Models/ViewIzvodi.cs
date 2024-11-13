using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewIzvodi
{
    public int Id { get; set; }

    public string BrojNaIzvod { get; set; } = null!;

    public DateTime? DatumNaIzvod { get; set; }

    public string Smetka { get; set; } = null!;

    public string? Zabeleska { get; set; }

    public string? BrojNaDokument { get; set; }

    public string? SifraPartner { get; set; }

    public string? NazivPartner { get; set; }

    public decimal? Dolzi { get; set; }

    public decimal? Pobaruva { get; set; }
}
