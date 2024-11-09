using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblGrupaNaArtikli
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Sifra { get; set; }

    public int? Status { get; set; }

    public int FirmaId { get; set; }

    public string? Image { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblFirma Firma { get; set; } = null!;

    public virtual ICollection<TblPodgrupaId> TblPodgrupaIds { get; set; } = new List<TblPodgrupaId>();
}
