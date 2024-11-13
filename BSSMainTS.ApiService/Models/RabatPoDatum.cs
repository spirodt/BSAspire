using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class RabatPoDatum
{
    public int? Broj { get; set; }

    public DateOnly? Datum { get; set; }

    public decimal? Rabat { get; set; }

    public int TipNaDokument { get; set; }

    public int TblDdvid { get; set; }
}
