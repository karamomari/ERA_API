using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblStandardRate
{
    public decimal StandardRateId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public DateTime? FromTime { get; set; }

    public DateTime? ToTime { get; set; }

    public decimal? ProductId { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Percentage { get; set; }

    public bool? IsIncrease { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
