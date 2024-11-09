using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNalogStavkiIzmenetum
{
    public int Id { get; set; }

    public int TblNalogIzmenetaId { get; set; }

    public int? TblNomativId { get; set; }

    public int? TblArtikalId { get; set; }

    public decimal? Kolicina { get; set; }

    public decimal? Rabat1 { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
