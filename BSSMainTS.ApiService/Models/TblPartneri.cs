using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblPartneri
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Adresa { get; set; }

    public string? Telefoni { get; set; }

    public string? Email { get; set; }

    public string? Edb { get; set; }

    public string? Mesto { get; set; }

    public int Tip { get; set; }

    public int? Status { get; set; }

    public int FirmaId { get; set; }

    public int? TblPresmetkovnaEdinicaId { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public string? Notes { get; set; }

    public int? DefaultKolicina { get; set; }

    public int? BrojNaStan { get; set; }

    public int? TipNaDostava { get; set; }

    public DateTime? DateModified { get; set; }

    public string? AltSifra { get; set; }

    public virtual ICollection<TblFaktura> TblFakturas { get; set; } = new List<TblFaktura>();

    public virtual ICollection<TblIzvodiStavki> TblIzvodiStavkis { get; set; } = new List<TblIzvodiStavki>();

    public virtual ICollection<TblPriem> TblPriems { get; set; } = new List<TblPriem>();

    public virtual ICollection<TblSmetka> TblSmetkas { get; set; } = new List<TblSmetka>();
}
