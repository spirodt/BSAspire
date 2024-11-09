using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblIzvodi
{
    public int Id { get; set; }

    public string BrojNaIzvod { get; set; } = null!;

    public string? Zabeleska { get; set; }

    public string Smetka { get; set; } = null!;

    public DateTime? DatumNaIzvod { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblIzvodiStavki> TblIzvodiStavkis { get; set; } = new List<TblIzvodiStavki>();
}
