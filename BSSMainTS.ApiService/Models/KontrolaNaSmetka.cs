using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class KontrolaNaSmetka
{
    public int SmetkaId { get; set; }

    public int BrojNaSmetka { get; set; }

    public decimal VkupenPromet { get; set; }

    public decimal VkupnoNalozi { get; set; }

    public decimal VkupnoFiskalna { get; set; }

    public decimal? VkupnoNeFiskalenPromet { get; set; }

    public DateTime DatumPocetok { get; set; }

    public DateTime? DatumKraj { get; set; }

    public string? FullName { get; set; }

    public int TblUserId { get; set; }

    public string? Zabeleska { get; set; }

    public bool? Zatvorena { get; set; }

    public int? Izmeneta { get; set; }

    public decimal? Fiskalna { get; set; }
}
