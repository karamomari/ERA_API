using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblStocktakingDetail
{
    public decimal StocktakingDetailsId { get; set; }

    public decimal? StocktakingMasterId { get; set; }

    public decimal? ProductId { get; set; }

    public decimal? BlanaceQty { get; set; }

    public decimal? Qty { get; set; }

    public decimal? DifferanceQty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? CostRate { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? UnitConversionId { get; set; }

    public decimal? BatchId { get; set; }

    public string? BatchNo { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal? FromGodownId { get; set; }

    public decimal? ToGodownId { get; set; }

    public decimal? RackId { get; set; }

    public decimal? Amount { get; set; }

    public int? SlNo { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
