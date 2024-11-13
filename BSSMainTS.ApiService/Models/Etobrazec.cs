using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class Etobrazec
{
    public long? Rbr { get; set; }

    public DateTime? DatumNaKnizenje { get; set; }

    public string? NazivIBrojNaDokument { get; set; }

    public DateTime DatumNaDokument { get; set; }

    public decimal NabavnaVrednost { get; set; }

    public decimal? ProdaznaVrednost { get; set; }

    public decimal? DnevenPromet { get; set; }
}
