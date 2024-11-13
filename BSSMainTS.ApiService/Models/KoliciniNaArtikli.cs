using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class KoliciniNaArtikli
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public string Naziv { get; set; } = null!;

    public decimal? Vlez { get; set; }

    public decimal? Izlez { get; set; }

    public decimal? Saldo { get; set; }

    public decimal? ZalihaSoVrednost { get; set; }
}
