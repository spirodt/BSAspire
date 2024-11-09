using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class DbVersion
{
    public int Id { get; set; }

    public string DbVersion1 { get; set; } = null!;

    public string LastAlterScriptName { get; set; } = null!;
}
