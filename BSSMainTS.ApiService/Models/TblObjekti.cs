using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblObjekti
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Sifra { get; set; }

    public int FirmaId { get; set; }

    public int? Status { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblSmetka> TblSmetkas { get; set; } = new List<TblSmetka>();
}
