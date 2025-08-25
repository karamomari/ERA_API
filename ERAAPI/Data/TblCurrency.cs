using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblCurrency
{
    public decimal CurrencyId { get; set; }

    public string? CurrencySymbol { get; set; }

    public string? CurrencyName { get; set; }

    public string? SubunitName { get; set; }

    public int? NoOfDecimalPlaces { get; set; }

    public string? Narration { get; set; }

    public bool? IsDefault { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
