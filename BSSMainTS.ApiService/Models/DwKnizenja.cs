using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class DwKnizenja
{
    public int? Id { get; set; }

    public DateTime? DatumNaKnizenje { get; set; }

    public DateTime? DatumNaPocetok { get; set; }

    public DateTime? DatumNaKraj { get; set; }

    public string? Sifra { get; set; }

    public string? Naziv { get; set; }

    public int? TipNaArtikal { get; set; }

    public decimal? ProdaznaCena { get; set; }

    public decimal? Kolicina { get; set; }

    public string? Kratenka { get; set; }

    public decimal? Procent { get; set; }

    public int? TipNaKnizenje { get; set; }

    public decimal? NabavnaCena { get; set; }

    public decimal? EdinecnaCena { get; set; }

    public decimal? IznosBezDdv { get; set; }

    public decimal? IznosDdv { get; set; }

    public decimal? IznosSoDdv { get; set; }

    public int? OtpecatenaFiskalna { get; set; }

    public int? PriemBroj { get; set; }

    public int? TblPriemId { get; set; }

    public int? SmetkaBroj { get; set; }

    public int? FakturaBroj { get; set; }

    public int? TblArtikalId { get; set; }

    public int? TblNormativId { get; set; }

    public string? VrabotenKojJaIzdalSmetkata { get; set; }

    public string? KodNaDokument { get; set; }

    public decimal? Rabat { get; set; }

    public decimal? IznosNaRabat { get; set; }

    public decimal? ProdaznaCenaSoRabat { get; set; }

    public int? TblDokumentId { get; set; }

    public int? TblObjektiIdod { get; set; }

    public int? TblObjektiIddo { get; set; }

    public int? DokumentBroj { get; set; }

    public int? TblSmetkaId { get; set; }

    public int? TblDdvid { get; set; }

    public string? OdObjekt { get; set; }

    public string? DoObjekt { get; set; }

    public int? TblPartnerId { get; set; }

    public string? AltSifraArtikal { get; set; }
}
