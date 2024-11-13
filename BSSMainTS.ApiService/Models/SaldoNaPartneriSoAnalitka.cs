using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class SaldoNaPartneriSoAnalitka
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public string Naziv { get; set; } = null!;

    public DateOnly? DatumNaValuta { get; set; }

    public string? BrojNaDokument { get; set; }

    public decimal IznosSoDdv { get; set; }

    public decimal Plateno { get; set; }

    public decimal? Saldo { get; set; }

    public string? Zabeleski { get; set; }

    public string? TipNaDostava { get; set; }
}
