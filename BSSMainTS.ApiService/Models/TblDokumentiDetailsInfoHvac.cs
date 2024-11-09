using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblDokumentiDetailsInfoHvac
{
    public int Id { get; set; }

    public int? TblDokumentId { get; set; }

    public string? Name { get; set; }

    public decimal? Capacity { get; set; }

    public decimal? LowRun { get; set; }

    public decimal? LowRunTotal { get; set; }

    public decimal? HighRun { get; set; }

    public decimal? HighRunTotal { get; set; }

    public string? Note { get; set; }

    public DateTime? DateTimeCreated { get; set; }

    public virtual TblDokumenti? TblDokument { get; set; }
}
