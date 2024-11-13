using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblUser
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public int NivoNaAdministracija { get; set; }

    public int? Status { get; set; }

    public int FirmaId { get; set; }

    public int? TblObjektId { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblFaktura> TblFakturas { get; set; } = new List<TblFaktura>();

    public virtual ICollection<TblSmetka> TblSmetkas { get; set; } = new List<TblSmetka>();

    public virtual ICollection<TblUserConfig> TblUserConfigs { get; set; } = new List<TblUserConfig>();
}
