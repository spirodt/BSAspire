using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class VwIndexText
{
    public string? OwnerName { get; set; }

    public string TableName { get; set; } = null!;

    public string? IndexName { get; set; }

    public string? DropSql { get; set; }

    public string? CreateSql { get; set; }

    public string? DisableSql { get; set; }

    public string? EnableSql { get; set; }
}
