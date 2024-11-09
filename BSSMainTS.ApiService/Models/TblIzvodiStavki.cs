using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblIzvodiStavki
{
    public int Id { get; set; }

    public int TblIzvodiId { get; set; }

    public int PartnerId { get; set; }

    public decimal Dolzi { get; set; }

    public decimal Pobaruva { get; set; }

    public int? DokumentId { get; set; }

    public int? FakturaId { get; set; }

    public int? PriemId { get; set; }

    public int? TipNaDokument { get; set; }

    public string BrojNaDokument { get; set; } = null!;

    public byte[] DataVersion { get; set; } = null!;

    public virtual TblPartneri Partner { get; set; } = null!;

    public virtual TblIzvodi TblIzvodi { get; set; } = null!;
}
