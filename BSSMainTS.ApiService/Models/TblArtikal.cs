using BSSMainTS.ApiService.Common;

namespace BSSMainTS.ApiService.Models;
[GeneratedCrudControllerRoute("api/Artikal")]
public partial class TblArtikal : EntityBase
{
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

    public virtual TblFirma Firma { get; set; } = null!;

    public virtual TblPodgrupaId Podgrupa { get; set; } = null!;

    public virtual ICollection<TblAkcijaNaArtikal> TblAkcijaNaArtikals { get; set; } = new List<TblAkcijaNaArtikal>();

    public virtual TblDdvstavka TblDdvstavka { get; set; } = null!;

    public virtual TblEdinecniMerki TblEdinecniMerki { get; set; } = null!;

    public virtual ICollection<TblNalogStavki> TblNalogStavkis { get; set; } = new List<TblNalogStavki>();

    public virtual ICollection<TblNormativStavki> TblNormativStavkis { get; set; } = new List<TblNormativStavki>();

    public virtual ICollection<TblPriemStavki> TblPriemStavkis { get; set; } = new List<TblPriemStavki>();
}
