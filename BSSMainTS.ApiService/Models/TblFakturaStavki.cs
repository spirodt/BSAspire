using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblFakturaStavki
{
    public int Id { get; set; }

    public int TblFakturaId { get; set; }

    public int TblArtikalId { get; set; }

    public bool Normativ { get; set; }

    public decimal Kolicina { get; set; }

    public decimal Iznos { get; set; }

    public decimal? Rabat1 { get; set; }

    public decimal? Rabat2 { get; set; }

    public decimal? Rabat3 { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblFaktura TblFaktura { get; set; } = null!;
}
