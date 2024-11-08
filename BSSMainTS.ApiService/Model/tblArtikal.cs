namespace BSSMainTS.ApiService.Model
{
    public class tblArtikal
    {
        public int ID { get; set; }
        public string? Sifra { get; set; }
        public string Naziv { get; set; }
        public int tblDDVStavkaID { get; set; }
        public int PodgrupaID { get; set; }
        public int tblEdinecniMerkiID { get; set; }
        public string? AltNaziv { get; set; }
        public string? AltSifra { get; set; }
        public string? KlucniZborovi { get; set; }
        public decimal? NabavnaCena { get; set; }
        public decimal? ProdaznaCena { get; set; }
        public int FirmaID { get; set; }
        public int? Status { get; set; }
        public int? EDMIzlez { get; set; }
        public decimal? KolicinaT { get; set; }
        public decimal? MinimalnaKolicinaNaZaliha { get; set; }
        public int? RedenBroj { get; set; }
        public string? Barkod1 { get; set; }
        public string? Barkod2 { get; set; }
        public string? AltNaziv2 { get; set; }
        public bool? SePecatiVoKujna { get; set; }
        public bool? SePacatiNaSank { get; set; }
        public int? DenoviZaGarancija { get; set; }
        public bool? DomasenProizvod { get; set; }
        public decimal? CenaNaGolemo { get; set; }
        public byte[] DataVersion { get; set; }
    }
}
