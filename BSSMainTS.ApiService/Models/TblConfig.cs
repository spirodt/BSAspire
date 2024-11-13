using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblConfig
{
    public int Id { get; set; }

    public string Opis { get; set; } = null!;

    public string Ime { get; set; } = null!;

    public int? Vrednost { get; set; }

    public int? NivoNaAdministracija { get; set; }

    public string? Range { get; set; }

    public string? ImeNaModul { get; set; }

    public int FirmaId { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
