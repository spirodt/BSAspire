namespace BSSMainTS.ApiService.Model
{
    public class tblGrupaNaArtikli
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string? Sifra { get; set; }
        public int? Status { get; set; }
        public int FirmaID { get; set; }
        public byte[] DataVersion { get; set; }
    }
}
