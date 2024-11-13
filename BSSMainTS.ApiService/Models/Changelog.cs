using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class Changelog
{
    public int ChangeNumber { get; set; }

    public DateTime? CompleteDt { get; set; }

    public string AppliedBy { get; set; } = null!;

    public string Description { get; set; } = null!;
}
