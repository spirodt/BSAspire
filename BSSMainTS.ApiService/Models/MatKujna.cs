﻿using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class MatKujna
{
    public string? Naziv { get; set; }

    public decimal? Kolicina { get; set; }

    public decimal? Iznos { get; set; }

    public decimal? ProdaznaCena { get; set; }

    public string? Sifra { get; set; }

    public int? Artikal { get; set; }
}