using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class Pltobrazec
{
    public long? Rbr { get; set; }

    public string? NazivNaStokata { get; set; }

    public string? EdM { get; set; }

    public decimal Kolicina { get; set; }

    public decimal? Cena { get; set; }

    public decimal Iznos { get; set; }

    public decimal DdvPriNabavka { get; set; }

    public decimal? StapkaNaDdvPropis { get; set; }

    public decimal? CenaProdazba { get; set; }

    public decimal? IznosProdazba { get; set; }

    public decimal? VkupnoDdvProdaznaVrednost { get; set; }

    public DateTime DatumNaPriem { get; set; }

    public int? TblPriemId { get; set; }

    public int? TblDokumentId { get; set; }

    public int? BrojNaPriem { get; set; }

    public string? DoObjekt { get; set; }
}
