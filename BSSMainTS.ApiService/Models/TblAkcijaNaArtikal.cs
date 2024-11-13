using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblAkcijaNaArtikal
{
    public int Id { get; set; }

    public DateOnly DatumPocetok { get; set; }

    public DateOnly DatumKraj { get; set; }

    public int TblArtikalId { get; set; }

    public decimal AkciskaCena { get; set; }

    public decimal? Rabat { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblArtikal TblArtikal { get; set; } = null!;
}
