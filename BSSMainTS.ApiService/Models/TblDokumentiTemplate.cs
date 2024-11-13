using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblDokumentiTemplate
{
    public int Id { get; set; }

    public int? TipNaDokumentId { get; set; }

    public int? TblArtikalId { get; set; }

    public int? TblNormativId { get; set; }

    public decimal? Cena { get; set; }

    public decimal? Kolicina { get; set; }

    public decimal? Iznos { get; set; }

    public decimal? Rabat1 { get; set; }
}
