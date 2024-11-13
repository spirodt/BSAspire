using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblClientConfiguracija
{
    public int Id { get; set; }

    public string? Setting { get; set; }

    public string? Value { get; set; }

    public string? Info { get; set; }
}
