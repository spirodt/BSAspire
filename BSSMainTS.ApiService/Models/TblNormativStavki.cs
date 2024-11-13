using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNormativStavki
{
    public int Id { get; set; }

    public int TblNormativId { get; set; }

    public int TblArtikalId { get; set; }

    public int? Status { get; set; }

    public decimal Kolicina { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblArtikal TblArtikal { get; set; } = null!;

    public virtual TblNormativ TblNormativ { get; set; } = null!;
}
