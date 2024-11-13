namespace BSSMainTS.ApiService.Models
{
    public class tblPodgrupa
    {
        public int ID { get; set; }
        public int GrupaID { get; set; }
        public string Naziv { get; set; }
        public int FirmaID { get; set; }
        public int? Status { get; set; }
        public byte[] DataVersion { get; set; }
    }
}
