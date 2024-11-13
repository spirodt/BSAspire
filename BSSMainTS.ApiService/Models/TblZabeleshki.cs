using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblZabeleshki
{
    public int Id { get; set; }

    public string Tip { get; set; } = null!;

    public string Zabeleshka { get; set; } = null!;

    public byte[] DataVersion { get; set; } = null!;
}
