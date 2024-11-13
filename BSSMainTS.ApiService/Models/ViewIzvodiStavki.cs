using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewIzvodiStavki
{
    public int Id { get; set; }

    public int TblIzvodiId { get; set; }

    public string? BrojNaIzvod { get; set; }

    public DateTime? DatumNaIzvod { get; set; }

    public int PartnerId { get; set; }

    public decimal? Dolzi { get; set; }

    public decimal? Pobaruva { get; set; }

    public string? SifraPartner { get; set; }

    public string? NazivPartner { get; set; }

    public decimal? IznosDokument { get; set; }

    public int? DokumentId { get; set; }

    public int? TipNaDokument { get; set; }

    public string BrojNaDokument { get; set; } = null!;
}
