using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblPriemStavki
{
    public int Id { get; set; }

    public int TblPriemId { get; set; }

    public int TblArtikalId { get; set; }

    public decimal Kolicina { get; set; }

    public decimal NabavnaCenaBezDdv { get; set; }

    public decimal NabavnaCenaSoDdv { get; set; }

    public decimal? Rabat1 { get; set; }

    public decimal? Rabat2 { get; set; }

    public decimal? Rabat3 { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblArtikal TblArtikal { get; set; } = null!;

    public virtual TblPriem TblPriem { get; set; } = null!;
}
