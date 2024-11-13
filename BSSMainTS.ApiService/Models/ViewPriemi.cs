using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class ViewPriemi
{
    public int Id { get; set; }

    public int PriemBroj { get; set; }

    public DateTime PriemDatum { get; set; }

    public int TblPartnerId { get; set; }

    public string? KodNaDokument { get; set; }

    public int TblUserId { get; set; }

    public int ObjektId { get; set; }

    public int? ValutaDenovi { get; set; }

    public int? KalkulacijaBroj { get; set; }

    public string? Zabeleska { get; set; }

    public string? Dobavuvac { get; set; }

    public string? Objekt { get; set; }

    public string? UserFullName { get; set; }

    public string? SifraPartner { get; set; }

    public decimal Ddviznos { get; set; }

    public decimal Ddviznos18 { get; set; }

    public decimal Ddviznos5 { get; set; }

    public decimal IznosBezDdv { get; set; }

    public decimal IznosSoDdv { get; set; }

    public decimal IznosSoDdvzaokruzeno { get; set; }

    public decimal ProdaznaVrednostSoDdv { get; set; }

    public string? IspratnicaFakturaBroj { get; set; }

    public DateTime? IspratnicaFakturaDatum { get; set; }

    public decimal? VkupenIznos { get; set; }

    public DateTime? DatumNaDospeanost { get; set; }

    public DateTime? DatumNaKreiranjeNaPriem { get; set; }
}
