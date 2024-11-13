using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblSmetkaIzmenetum
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public DateTime DatumPocetok { get; set; }

    public DateTime? DatumKraj { get; set; }

    public int TblUserId { get; set; }

    public int SmenaId { get; set; }

    public bool? Zatvorena { get; set; }

    public int FirmaId { get; set; }

    public int ObjektId { get; set; }

    public string? Zabeleska { get; set; }

    public int? Izmeneta { get; set; }

    public DateTime? DatumNaIzmena { get; set; }

    public int? TblSmetkaIzmenetaId { get; set; }

    public int? TblPartnerId { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
