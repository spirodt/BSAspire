using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ListaNaDolznici
{
    public string? Sifra { get; set; }

    public string Naziv { get; set; } = null!;

    public string? BrojNaDokument { get; set; }

    public decimal IznosSoDdv { get; set; }

    public decimal Plateno { get; set; }

    public decimal? Saldo { get; set; }
}
