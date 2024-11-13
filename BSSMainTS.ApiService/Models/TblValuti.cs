using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblValuti
{
    public int Id { get; set; }

    public string Opis { get; set; } = null!;

    public string Kratenka { get; set; } = null!;

    public byte[] DataVersion { get; set; } = null!;
}
