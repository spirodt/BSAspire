using BSSMainTS.ApiService.Common;

namespace BSSMainTS.ApiService.Models;
[GeneratedCrudControllerRoute("api/Faktura")]
public partial class TblFaktura : EntityBase
{
    public int Broj { get; set; }

    public DateOnly Datum { get; set; }

    public int TblPartnerId { get; set; }

    public int? TblZiroSmetkaId { get; set; }

    public int? TblBankaId { get; set; }

    public int TblUserId { get; set; }

    public DateOnly Valuta { get; set; }

    public string? Zabeleska { get; set; }

    public string? ListaNaIspratnici { get; set; }

    public string? KodNaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblBanki? TblBanka { get; set; }

    public virtual ICollection<TblFakturaStavki> TblFakturaStavkis { get; set; } = new List<TblFakturaStavki>();

    public virtual ICollection<TblKnizenjeM> TblKnizenjeMs { get; set; } = new List<TblKnizenjeM>();

    public virtual TblPartneri TblPartner { get; set; } = null!;

    public virtual TblUser TblUser { get; set; } = null!;

    public virtual TblZiroSmetki? TblZiroSmetka { get; set; }
}
