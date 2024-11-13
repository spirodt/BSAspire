using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewArtikaliNormativi
{
    public int Id { get; set; }

    public string? Sifra { get; set; }

    public int Status { get; set; }

    public string? Naziv { get; set; }

    public string? KlucniZborovi { get; set; }

    public decimal ProdaznaCena { get; set; }

    public int? GrupaId { get; set; }

    public string Normativ { get; set; } = null!;

    public int FirmaId { get; set; }

    public int? PodgrupaId { get; set; }

    public string? Image { get; set; }

    public int? RedenBroj { get; set; }
}
