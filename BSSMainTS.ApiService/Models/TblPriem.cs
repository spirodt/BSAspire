using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblPriem
{
    public int Id { get; set; }

    public int PriemBroj { get; set; }

    public DateTime PriemDatum { get; set; }

    public int TblPartnerId { get; set; }

    public int TblUserId { get; set; }

    public int ObjektId { get; set; }

    public string? IspratnicaFakturaBroj { get; set; }

    public DateTime? IspratnicaFakturaDatum { get; set; }

    public int? ValutaDenovi { get; set; }

    public int? KalkulacijaBroj { get; set; }

    public string? Zabeleska { get; set; }

    public decimal? VkupenIznos { get; set; }

    public DateTime? DatumNaDospeanost { get; set; }

    public DateTime? DatumNaKreiranjeNaPriem { get; set; }

    public string? KodNaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblKnizenjeM> TblKnizenjeMs { get; set; } = new List<TblKnizenjeM>();

    public virtual TblPartneri TblPartner { get; set; } = null!;

    public virtual ICollection<TblPriemStavki> TblPriemStavkis { get; set; } = new List<TblPriemStavki>();
}
