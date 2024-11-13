using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewDokumentiStavki
{
    public int Id { get; set; }

    public int TblDokumentId { get; set; }

    public string? AltSifra { get; set; }

    public string? NormativSifra { get; set; }

    public int? BrojNaDokument { get; set; }

    public string? TipNadokument { get; set; }

    public string? ArikalNaziv { get; set; }

    public int? ArtikalId { get; set; }

    public string? NotesText { get; set; }

    public string? NotesBroj { get; set; }

    public int? NotesRef { get; set; }

    public string? NormativNaziv { get; set; }

    public int? NormativId { get; set; }

    public int IsNormativ { get; set; }

    public string? NazivNaProdukt { get; set; }

    public decimal? Ddvstapka { get; set; }

    public string? EdinecnaMerka { get; set; }

    public decimal? Ddviznos { get; set; }

    public decimal? IznosBezDdv { get; set; }

    public decimal? CenaBezDdv { get; set; }

    public decimal? CenaSoRabatIddv { get; set; }

    public decimal Kolicina { get; set; }

    public decimal? Cena { get; set; }

    public decimal? Rabat1 { get; set; }

    public decimal Iznos { get; set; }

    public int? TipNaDokumentId { get; set; }

    public DateOnly? DatumNaDokument { get; set; }

    public decimal? ProsecnaNabavnaCena { get; set; }

    public decimal? ProsecnaNabavnaCenaBezDdv { get; set; }

    public decimal? NabavnaVrednostBezDdviznos { get; set; }

    public decimal PlanskaCena { get; set; }

    public decimal PlanskaVrednost { get; set; }

    public decimal? ProdaznaCena { get; set; }

    public decimal ProdaznaVrednostSoDdv { get; set; }
}
