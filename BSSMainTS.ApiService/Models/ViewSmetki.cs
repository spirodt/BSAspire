using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewSmetki
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

    public int? ImaPopust { get; set; }

    public decimal? ProcentNaPopust { get; set; }

    public int? Izmeneta { get; set; }

    public int? TblPartnerId { get; set; }

    public string? KodNaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public string? FullName { get; set; }

    public string? Partner { get; set; }

    public int? PresmetkovnaEdinicaId { get; set; }

    public string? PresmetkovnaEdinica { get; set; }

    public decimal? IznosBezDdv { get; set; }

    public decimal? Iznos { get; set; }

    public decimal? PresmetanDdv { get; set; }
}
