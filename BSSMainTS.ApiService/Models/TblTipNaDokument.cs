using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblTipNaDokument
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public int? Status { get; set; }

    public bool SeKnizi { get; set; }

    public string? ReportFileName { get; set; }

    public int TipNaKnizenje { get; set; }

    public int FirmaId { get; set; }

    public string? Naslov { get; set; }

    public int Interen { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
