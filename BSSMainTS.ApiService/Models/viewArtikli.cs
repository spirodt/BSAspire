using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewArtikli
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public string NazivArtikal { get; set; } = null!;

    public decimal? NabavnaCena { get; set; }

    public decimal ProdaznaCena { get; set; }

    public string? PodGrupaArtikal { get; set; }

    public string? GrupaArtikal { get; set; }

    public string? Naziv { get; set; }

    public decimal? Procent { get; set; }

    public string? AltSifra { get; set; }

    public string? AltNaziv { get; set; }

    public int FirmaId { get; set; }

    public string? Edm { get; set; }

    public string? Image { get; set; }

    public decimal? MinimalnaKolicinaNaZaliha { get; set; }

    public decimal? KolicinaT { get; set; }

    public int? Status { get; set; }

    public int? Edmizlez { get; set; }

    public int? RedenBroj { get; set; }

    public string? Barkod1 { get; set; }

    public string? Barkod2 { get; set; }

    public string? AltNaziv2 { get; set; }

    public bool? SePecatiVoKujna { get; set; }

    public bool? SePacatiNaSank { get; set; }

    public int? DenoviZaGarancija { get; set; }

    public int MomentalZaliha { get; set; }
}
