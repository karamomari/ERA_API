using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblUnitConvertion
{
    public decimal UnitconversionId { get; set; }

    public decimal? MainUnitId { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? ConversionRate { get; set; }

    public decimal? Quantities { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
