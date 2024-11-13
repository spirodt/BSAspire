using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblFirma
{
    public int Id { get; set; }

    public string ImeNaFirma { get; set; } = null!;

    public string? DanocenBroj { get; set; }

    public string? BankaDeponent { get; set; }

    public string? Grad { get; set; }

    public string? Adresa { get; set; }

    public string? PostenskiBroj { get; set; }

    public string? Telefon { get; set; }

    public string? Faks { get; set; }

    public string? Email { get; set; }

    public string? MaticenBroj { get; set; }

    public int? Status { get; set; }

    public byte[]? Image1 { get; set; }

    public byte[]? Image2 { get; set; }

    public byte[]? Image3 { get; set; }

    public string? ZiroSmetka { get; set; }

    public string? TxIdfirma { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual ICollection<TblArtikal> TblArtikals { get; set; } = new List<TblArtikal>();

    public virtual ICollection<TblGrupaNaArtikli> TblGrupaNaArtiklis { get; set; } = new List<TblGrupaNaArtikli>();

    public virtual ICollection<TblNalog> TblNalogs { get; set; } = new List<TblNalog>();

    public virtual ICollection<TblNormativ> TblNormativs { get; set; } = new List<TblNormativ>();

    public virtual ICollection<TblSmetka> TblSmetkas { get; set; } = new List<TblSmetka>();
}
