using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblKursnaListum
{
    public int Id { get; set; }

    public int? TblValutaId { get; set; }

    public decimal? Kurs { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
