using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblEdinecniMerki
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public string Kratenka { get; set; } = null!;

    public int FirmaId { get; set; }

    public int? Status { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblArtikal> TblArtikals { get; set; } = new List<TblArtikal>();
}
