using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblPodgrupaId
{
    public int Id { get; set; }

    public int GrupaId { get; set; }

    public string Naziv { get; set; } = null!;

    public int FirmaId { get; set; }

    public int? Status { get; set; }

    public string? Image { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblGrupaNaArtikli Grupa { get; set; } = null!;

    public virtual ICollection<TblArtikal> TblArtikals { get; set; } = new List<TblArtikal>();
}
