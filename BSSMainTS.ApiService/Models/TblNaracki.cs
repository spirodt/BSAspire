using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNaracki
{
    public int Id { get; set; }

    public int NarackaBroj { get; set; }

    public string Opis { get; set; } = null!;

    public DateTime DatumNaNaracka { get; set; }

    public string Ime { get; set; } = null!;

    public string? Kontakt { get; set; }

    public string? OdObjekt { get; set; }

    public bool Zavrsena { get; set; }

    public string? KodNaDokument { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
