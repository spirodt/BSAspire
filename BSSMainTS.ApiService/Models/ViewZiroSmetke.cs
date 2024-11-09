using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewZiroSmetke
{
    public int Id { get; set; }

    public string? Partner { get; set; }

    public string? Banka { get; set; }

    public string ZiroSmetka { get; set; } = null!;

    public int? Status { get; set; }

    public int FirmaId { get; set; }
}
