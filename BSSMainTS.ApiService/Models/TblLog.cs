using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblLog
{
    public long Id { get; set; }

    public Guid Sesija { get; set; }

    public string Akcija { get; set; } = null!;

    public DateTime DatumIvreme { get; set; }

    public int? Status { get; set; }

    public virtual TblSesija SesijaNavigation { get; set; } = null!;
}
