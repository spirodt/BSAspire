using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblSesija
{
    public long Id { get; set; }

    public Guid Sesija { get; set; }

    public DateTime Pocnata { get; set; }

    public int FirmaId { get; set; }

    public int UserId { get; set; }

    public DateTime? Zavrsena { get; set; }

    public virtual ICollection<TblLog> TblLogs { get; set; } = new List<TblLog>();
}
