using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblUserConfig
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string ObjectName { get; set; } = null!;

    public string? ConfigData { get; set; }

    public DateTime DateOfCreation { get; set; }

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblUser User { get; set; } = null!;
}
