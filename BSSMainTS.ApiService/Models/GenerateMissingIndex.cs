using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class GenerateMissingIndex
{
    public string? NonIndexedColTableName { get; set; }

    public string? NonIndexedColColumnName { get; set; }

    public string ConstraintName { get; set; } = null!;
}
