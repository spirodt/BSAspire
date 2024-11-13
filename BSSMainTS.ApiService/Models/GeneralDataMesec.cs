using System;
using System.Collections.Generic;

namespace BSSMainTS.ApiService.Models;

public partial class GeneralDataMesec
{
    public int? Mesec { get; set; }

    public decimal? SupplierTotalBill { get; set; }

    public decimal? SupplierLowTariffKwh { get; set; }

    public decimal? SupplierHighTariffKwh { get; set; }

    public decimal? LostElectricityLowTariff { get; set; }

    public decimal? LostElectricityHighTariff { get; set; }

    public decimal? WarmWaterMaintainingFee { get; set; }

    public decimal? HidrokitUsers { get; set; }

    public decimal? HidrokitLowTariffKwh { get; set; }

    public decimal? HidrokitHighTariffKwh { get; set; }

    public decimal? TotalWarmWaterConsumed { get; set; }

    public decimal? IndoorsLowTariffMin { get; set; }

    public decimal? IndoorsLowTariffTotalMin { get; set; }

    public decimal? IndoorsHighTariffMin { get; set; }

    public decimal? IndoorsHighTariffTotalMin { get; set; }

    public decimal? WarmWaterTotalCost { get; set; }

    public decimal? WarmWaterHeatingTotalPrice { get; set; }

    public decimal? WarmWaterPrice { get; set; }

    public decimal? IndoorsTotalPrice { get; set; }

    public int? Godina { get; set; }
}
