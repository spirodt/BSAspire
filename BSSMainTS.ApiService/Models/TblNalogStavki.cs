using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNalogStavki
{
    public int Id { get; set; }

    public int TblNalogId { get; set; }

    public int? TblNomativId { get; set; }

    public int? TblArtikalId { get; set; }

    public decimal? Kolicina { get; set; }

    public decimal? Rabat1 { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblArtikal? TblArtikal { get; set; }

    public virtual TblNalog TblNalog { get; set; } = null!;

    public virtual TblNormativ? TblNomativ { get; set; }
}
