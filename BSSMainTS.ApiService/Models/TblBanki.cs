using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblBanki
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public string Naziv { get; set; } = null!;

    public int? Status { get; set; }

    public int FirmaId { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblFaktura> TblFakturas { get; set; } = new List<TblFaktura>();
}
