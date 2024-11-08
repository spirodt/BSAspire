namespace BSSMainTS.Web;

public class ArtikalApiClient(HttpClient httpClient)
{
    public async Task<Artikal[]> GetArtikliAsync(int maxItems = 10000, CancellationToken cancellationToken = default)
    {
        List<Artikal>? artikli = null;

        await foreach (var listaSoArtikli in httpClient.GetFromJsonAsAsyncEnumerable<Artikal>("/api/Artikal", cancellationToken))
        {
            if (artikli?.Count >= maxItems)
            {
                break;
            }
            if (listaSoArtikli is not null)
            {
                artikli ??= [];
                artikli.Add(listaSoArtikli);
            }
        }

        return artikli?.ToArray() ?? [];
    }
}

public record Artikal
{
    public int ID { get; set; }
    public string? Sifra { get; set; }
    public  string NazivArtikal { get; set; }
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