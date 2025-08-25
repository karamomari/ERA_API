using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblAdditionalCost
{
    public decimal AdditionalCostId { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? VoucherMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public decimal? AdditionalCostMasterId { get; set; }

    public decimal? LedgerId { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsEstimation { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
