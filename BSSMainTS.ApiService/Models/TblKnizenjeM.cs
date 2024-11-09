using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblKnizenjeM
{
    public int Id { get; set; }

    public int? TblNormativId { get; set; }

    public int? TblArtikalId { get; set; }

    public int TipNaArtikal { get; set; }

    public decimal ProdaznaCena { get; set; }

    public decimal Kolicina { get; set; }

    public string? Sifra { get; set; }

    public int TblEdinecnaMerka { get; set; }

    public int TblDdvid { get; set; }

    public int TipNaKnizenje { get; set; }

    public decimal NabavnaCena { get; set; }

    public decimal? EdinecnaCena { get; set; }

    public decimal IznosSoDdv { get; set; }

    public decimal IznosBezDdv { get; set; }

    public decimal IznosDdv { get; set; }

    public DateTime DatumNaKnizenje { get; set; }

    public int TblUserId { get; set; }

    public int TblObjektiId { get; set; }

    public DateTime DatumNaPocetok { get; set; }

    public DateTime DatumNaKraj { get; set; }

    public int? TblSmetkaId { get; set; }

    public int? TblFakturaId { get; set; }

    public int? TblPriemId { get; set; }

    public int? OtpecatenaFiskalna { get; set; }

    public int? TblValutaId { get; set; }

    public decimal? Rabat { get; set; }

    public decimal? IznosNaRabat { get; set; }

    public decimal? ProdaznaCenaSoRabat { get; set; }

    public int? TblObjektiIdod { get; set; }

    public int? TblObjektiIddo { get; set; }

    public int? TblDokumentId { get; set; }

    public string? KodNaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblDokumenti? TblDokument { get; set; }

    public virtual TblFaktura? TblFaktura { get; set; }

    public virtual TblPriem? TblPriem { get; set; }

    public virtual TblSmetka? TblSmetka { get; set; }
}
