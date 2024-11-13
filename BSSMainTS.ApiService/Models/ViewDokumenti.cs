using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewDokumenti
{
    public int Id { get; set; }

    public int Broj { get; set; }

    public string? BrojChar { get; set; }

    public int TipDokumentId { get; set; }

    public string? TipNaDokument { get; set; }

    public DateOnly Datum { get; set; }

    public string? Zabeleska { get; set; }

    public string? ObejektDo { get; set; }

    public string? ObjektOd { get; set; }

    public string? UserName { get; set; }

    public int? DoObjektId { get; set; }

    public int OdObjektId { get; set; }

    public int? TblPartnerId { get; set; }

    public int? TipNaKnizenje { get; set; }

    public string? KodNaDokument { get; set; }

    public string? UniqueIdPlacanje { get; set; }

    public DateTime? DatumNaValuta { get; set; }

    public DateTime? DatumPeriod { get; set; }

    public string? BrojNaDokument { get; set; }

    public string? Notes { get; set; }

    public string NazivPartner { get; set; } = null!;

    public string SifraPartner { get; set; } = null!;

    public decimal Ddviznos { get; set; }

    public decimal Ddviznos18 { get; set; }

    public decimal Ddviznos5 { get; set; }

    public decimal IznosBezDdv { get; set; }

    public decimal IznosSoDdv { get; set; }

    public int? Interen { get; set; }
}
