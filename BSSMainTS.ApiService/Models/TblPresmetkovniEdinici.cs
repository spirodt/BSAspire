using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblPresmetkovniEdinici
{
    public int Id { get; set; }

    public string Sifra { get; set; } = null!;

    public string Naziv { get; set; } = null!;

    public int FirmaId { get; set; }

    public string? Zabeleska { get; set; }

    public int? Status { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
