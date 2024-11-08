namespace BSSMainTS.ApiService.Model
{
    public class viewArtikli
    {
        public int ID { get; set; }
        public string? Sifra { get; set; }
        public required string NazivArtikal { get; set; }
        public decimal ProdaznaCena { get; set; }
        public string? PodGrupaArtikal { get; set; }
        public string? GrupaArtikal { get; set; }
        public string? Naziv { get; set; }
        public decimal? Procent { get; set; }
        public string? EDM { get; set; }
        public int? EDMIzlez { get; set; }
        public int? RedenBroj { get; set; }
        public string? Barkod1 { get; set; }
        public bool? SePecatiVoKujna { get; set; }
        public bool? SePacatiNaSank { get; set; }
    }
}
