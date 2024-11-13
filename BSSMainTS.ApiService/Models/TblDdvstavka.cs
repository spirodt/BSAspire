using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblDdvstavka
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public decimal Procent { get; set; }

    public int FirmaId { get; set; }

    public int Grupa { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblArtikal> TblArtikals { get; set; } = new List<TblArtikal>();
}
