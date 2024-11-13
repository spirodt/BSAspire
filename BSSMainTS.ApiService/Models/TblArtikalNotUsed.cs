using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblArtikalNotUsed
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public string Naziv { get; set; } = null!;

    public int TblDdvstavkaId { get; set; }

    public int PodgrupaId { get; set; }

    public int TblEdinecniMerkiId { get; set; }

    public string? AltNaziv { get; set; }

    public string? AltSifra { get; set; }

    public string? KlucniZborovi { get; set; }

    public decimal? NabavnaCena { get; set; }

    public decimal ProdaznaCena { get; set; }

    public int FirmaId { get; set; }

    public int? Status { get; set; }

    public int? Edmizlez { get; set; }

    public decimal? KolicinaT { get; set; }

    public decimal? MinimalnaKolicinaNaZaliha { get; set; }

    public int? RedenBroj { get; set; }

    public string? Barkod1 { get; set; }

    public string? Barkod2 { get; set; }

    public string? AltNaziv2 { get; set; }

    public string? Image { get; set; }

    public bool? SePecatiVoKujna { get; set; }

    public bool? SePacatiNaSank { get; set; }

    public int? DenoviZaGarancija { get; set; }

    public bool? DomasenProizvod { get; set; }

    public decimal? CenaNaGolemo { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
