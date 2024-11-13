using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblFiskalniSmetki
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public DateTime Datum { get; set; }

    public decimal Iznos { get; set; }

    public bool? Stornirana { get; set; }

    public int TblSmetkaId { get; set; }

    public int FirmaId { get; set; }

    public string? KodNaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblSmetka TblSmetka { get; set; } = null!;
}
