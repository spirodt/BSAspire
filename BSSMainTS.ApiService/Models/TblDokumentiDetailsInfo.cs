using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblDokumentiDetailsInfo
{
    public int Id { get; set; }

    public int TblDokumentId { get; set; }

    public string? WaterMeter { get; set; }

    public decimal? WaterMeterOld { get; set; }

    public decimal? WaterMeterNew { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public virtual TblDokumenti TblDokument { get; set; } = null!;
}
