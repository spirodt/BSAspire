using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNalogIzmenetum
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public string? Zabeleska { get; set; }

    public DateTime DatumPocetok { get; set; }

    public DateTime? DatumKraj { get; set; }

    public int FirmaId { get; set; }

    public int SmenaId { get; set; }

    public bool? Zavrsen { get; set; }

    public int TipNaNalog { get; set; }

    public int SmetkaId { get; set; }

    public DateTime? DatumNaIzmena { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
