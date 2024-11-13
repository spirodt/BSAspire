using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblSmetkaStavki
{
    public int Id { get; set; }

    public int TblSmetkaId { get; set; }

    public int TblNalogId { get; set; }

    public int? Status { get; set; }

    public int Kolicina { get; set; }

    public decimal Cena { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblNalog TblNalog { get; set; } = null!;

    public virtual TblSmetka TblSmetka { get; set; } = null!;
}
