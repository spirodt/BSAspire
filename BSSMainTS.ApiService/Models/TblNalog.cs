using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNalog
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public string? Zabeleska { get; set; }

    public DateTime DatumPocetok { get; set; }

    public DateTime? DatumKraj { get; set; }

    public int FirmaId { get; set; }

    public int SmenaId { get; set; }

    public bool? Zavrsen { get; set; }

    public int TipNaNalog { get; set; }

    public int SmetkaId { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblFirma Firma { get; set; } = null!;

    public virtual ICollection<TblNalogStavki> TblNalogStavkis { get; set; } = new List<TblNalogStavki>();

    public virtual ICollection<TblSmetkaStavki> TblSmetkaStavkis { get; set; } = new List<TblSmetkaStavki>();
}
