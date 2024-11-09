using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewDospeaniFakturi
{
    public int TipNaDokument { get; set; }

    public int Id { get; set; }

    public int TblPartnerId { get; set; }

    public int Broj { get; set; }

    public string? BrojNaFakturaSporedPartner { get; set; }

    public DateOnly Valuta { get; set; }

    public DateOnly Datum { get; set; }

    public string? DocNaziv { get; set; }

    public string? SifraPartner { get; set; }

    public string? NazivPartner { get; set; }

    public decimal IznosNaDokument { get; set; }

    public decimal? PreostanatoZaPlacanje { get; set; }

    public decimal PlatenoZaDokument { get; set; }
}
