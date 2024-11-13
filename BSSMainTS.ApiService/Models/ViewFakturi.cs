using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewFakturi
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public string? BrojNaFakturaSporedPartner { get; set; }

    public DateOnly Datum { get; set; }

    public DateOnly Valuta { get; set; }

    public string? Partner { get; set; }

    public string? ZiroSmetka { get; set; }

    public string? KodNaDokument { get; set; }

    public string? Banka { get; set; }

    public string? ListaNaIspratnici { get; set; }

    public decimal FakturiranDdv { get; set; }

    public decimal IznosBezDdv { get; set; }

    public decimal Iznos { get; set; }

    public int TblPartnerId { get; set; }

    public string? Zabeleska { get; set; }

    public string? SifraPartner { get; set; }

    public decimal Ddv18 { get; set; }

    public decimal Ddv5 { get; set; }
}
