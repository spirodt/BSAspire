using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblSmetka
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public DateTime DatumPocetok { get; set; }

    public DateTime? DatumKraj { get; set; }

    public int TblUserId { get; set; }

    public int SmenaId { get; set; }

    public bool? Zatvorena { get; set; }

    public int FirmaId { get; set; }

    public int ObjektId { get; set; }

    public string? Zabeleska { get; set; }

    public int? ImaPopust { get; set; }

    public decimal? ProcentNaPopust { get; set; }

    public int? Izmeneta { get; set; }

    public int? TblPartnerId { get; set; }

    public string? KodNaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblFirma Firma { get; set; } = null!;

    public virtual TblObjekti Objekt { get; set; } = null!;

    public virtual ICollection<TblFiskalniSmetki> TblFiskalniSmetkis { get; set; } = new List<TblFiskalniSmetki>();

    public virtual ICollection<TblKnizenjeM> TblKnizenjeMs { get; set; } = new List<TblKnizenjeM>();

    public virtual TblPartneri? TblPartner { get; set; }

    public virtual ICollection<TblSmetkaStavki> TblSmetkaStavkis { get; set; } = new List<TblSmetkaStavki>();

    public virtual TblUser TblUser { get; set; } = null!;
}
