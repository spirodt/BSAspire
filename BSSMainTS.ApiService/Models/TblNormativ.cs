using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNormativ
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public int? Status { get; set; }

    public int FirmaId { get; set; }

    public string? Sifra { get; set; }

    public int PodgrupaId { get; set; }

    public string? KlucniZborovi { get; set; }

    public decimal Cena { get; set; }

    public int TblDdvstavkaId { get; set; }

    public int? RedenBroj { get; set; }

    public string? AltNaziv { get; set; }

    public string? AltNaziv2 { get; set; }

    public string? Image { get; set; }

    public bool? SePecatiVoKujna { get; set; }

    public bool? SePacatiNaSank { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblFirma Firma { get; set; } = null!;

    public virtual ICollection<TblNalogStavki> TblNalogStavkis { get; set; } = new List<TblNalogStavki>();

    public virtual ICollection<TblNormativStavki> TblNormativStavkis { get; set; } = new List<TblNormativStavki>();
}
