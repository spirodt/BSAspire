using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblZiroSmetki
{
    public int Id { get; set; }

    public string ZiroSmetka { get; set; } = null!;

    public int TblPartnerId { get; set; }

    public int TblBankaId { get; set; }

    public int FirmaId { get; set; }

    public string? Status { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblFaktura> TblFakturas { get; set; } = new List<TblFaktura>();
}
