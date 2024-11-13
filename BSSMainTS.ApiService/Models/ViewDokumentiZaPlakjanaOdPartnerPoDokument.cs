using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewDokumentiZaPlakjanaOdPartnerPoDokument
{
    public int TipNaDokument { get; set; }

    public int Id { get; set; }

    public int? TblPartnerId { get; set; }

    public int Broj { get; set; }

    public DateTime Datum { get; set; }

    public string? DocNaziv { get; set; }

    public decimal IznosNaDokument { get; set; }

    public decimal? PreostanatoZaPlacanje { get; set; }

    public decimal PlatenoZaDokument { get; set; }
}
