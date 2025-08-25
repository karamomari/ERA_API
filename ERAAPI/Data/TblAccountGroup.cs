using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblAccountGroup
{
    public decimal AccountGroupId { get; set; }

    public string? AccountGroupName { get; set; }

    public string? AccountGroupType { get; set; }

    public decimal? GroupUnder { get; set; }

    public string? Narration { get; set; }

    public bool? IsDefault { get; set; }

    public string? Nature { get; set; }

    public bool? AffectGrossProfit { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
