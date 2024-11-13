using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class TblElektronskoPracanje
{
    public int Id { get; set; }

    public int DokumentId { get; set; }

    public string Naziv { get; set; } = null!;

    public string? Zabeleska { get; set; }

    public string DokumentValue { get; set; } = null!;

    public int? Status { get; set; }

    public int FirmaId { get; set; }

    public string PratenOd { get; set; } = null!;

    public string PratenDo { get; set; } = null!;

    public DateTime DatumNaPracanje { get; set; }

    public DateTime? DatumNaPoslednaIzmenaNaStatus { get; set; }

    public bool PratenPrimen { get; set; }

    public DateTime? DatumNaPotvrda { get; set; }

    public DateTime? DatumNaKnizenje { get; set; }

    public string GeneriranKodNaDokument { get; set; } = null!;

    public int Odobjekt { get; set; }

    public int DoObjekt { get; set; }

    public byte[] DataVersion { get; set; } = null!;
}
