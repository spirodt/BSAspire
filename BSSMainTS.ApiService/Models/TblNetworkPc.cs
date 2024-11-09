using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblNetworkPc
{
    public int Id { get; set; }

    public string? Pcname { get; set; }

    public string? HostName { get; set; }

    public string? Ipaddres { get; set; }

    public int? Number { get; set; }

    public int? Status { get; set; }

    public int? FirmaId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? PoslednaSmetka { get; set; }

    public int? TblArtikalId { get; set; }

    public string? RUserName { get; set; }

    public string? RPassWord { get; set; }

    public string? ClientPassword { get; set; }

    public string? Grupa { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
