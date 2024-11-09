using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewZaliha
{
    public int Id { get; set; }

    public DateTime DatumNaKnizenje { get; set; }

    public DateTime DatumNaPocetok { get; set; }

    public int? TblArtikalId { get; set; }

    public decimal? Ddvstapka { get; set; }

    public string? EdinecnaMerkaIzlez { get; set; }

    public string? Naziv { get; set; }

    public string? Kratenka { get; set; }

    public decimal? EdinecnaCena { get; set; }

    public decimal IznosBezDdv { get; set; }

    public decimal IznosDdv { get; set; }

    public string? KodNaDokument { get; set; }

    public decimal IznosSoDdv { get; set; }

    public decimal NabavnaCena { get; set; }

    public decimal? NabavenIznosBezDdv { get; set; }

    public decimal ProdaznaCena { get; set; }

    public int? SmetkaBroj { get; set; }

    public int? PriemBroj { get; set; }

    public int? FakturaBroj { get; set; }

    public string? NormativNaziv { get; set; }

    public int? DokumentBroj { get; set; }

    public int? TblSmetkaId { get; set; }

    public decimal KolicinaPoMerkaIzlez { get; set; }

    public decimal KolicinaVlez { get; set; }

    public decimal? KolicinaIzlez { get; set; }

    public decimal? KolicinaZaliha { get; set; }

    public string? VrabotenKojJaIzdalSmetkata { get; set; }

    public decimal? OtpecatenaFiskalna { get; set; }

    public int TipNaKnizenje { get; set; }

    public string? AltSifraArtikal { get; set; }

    public string? Sifra { get; set; }

    public decimal? PreostanataKolicinaNaZaliha { get; set; }
}
