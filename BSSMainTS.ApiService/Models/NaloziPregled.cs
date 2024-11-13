using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class NaloziPregled
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public int SmetkaId { get; set; }

    public string? Zabeleska { get; set; }

    public decimal Suma { get; set; }

    public int Status { get; set; }

    public DateTime DatumPocetok { get; set; }

    public int TipNaNalog { get; set; }
}
