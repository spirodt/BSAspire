using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblZalihaNaArtikli
{
    public int Id { get; set; }

    public DateTime Datum { get; set; }

    public int TblArtikalId { get; set; }

    public decimal Vlez { get; set; }

    public decimal Izlez { get; set; }

    public int TipDokument { get; set; }

    public int IdnaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
