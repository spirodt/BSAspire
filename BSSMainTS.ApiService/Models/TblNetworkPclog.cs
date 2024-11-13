using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNetworkPclog
{
    public int Id { get; set; }

    public string? Akcija { get; set; }

    public int? TblNetworkPcid { get; set; }

    public DateTime? Datum { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
