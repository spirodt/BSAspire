using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblDokumenti
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public int TipNaDokument { get; set; }

    public DateOnly Datum { get; set; }

    public int OdObjektId { get; set; }

    public int? DoObjektId { get; set; }

    public int TblUserId { get; set; }

    public string? Zabeleska { get; set; }

    public int? TblPartnerId { get; set; }

    public int FirmaId { get; set; }

    public string? KodNaDokument { get; set; }

    public string? BrojNaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public string? UniqueIdPlacanje { get; set; }

    public DateTime? DatumNaValuta { get; set; }

    public DateTime? DatumPeriod { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<TblDokumentStavki> TblDokumentStavkis { get; set; } = new List<TblDokumentStavki>();

    public virtual ICollection<TblDokumentiDetailsInfoHvac> TblDokumentiDetailsInfoHvacs { get; set; } = new List<TblDokumentiDetailsInfoHvac>();

    public virtual ICollection<TblDokumentiDetailsInfo> TblDokumentiDetailsInfos { get; set; } = new List<TblDokumentiDetailsInfo>();

    public virtual ICollection<TblKnizenjeM> TblKnizenjeMs { get; set; } = new List<TblKnizenjeM>();
}
