using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblPurchaseRequisitionDetail
{
    public decimal PurchaseRequisitionDetailsId { get; set; }

    public decimal? PurchaseRequisitionMasterId { get; set; }

    public decimal? ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? UnitId { get; set; }

    public string? Unit { get; set; }

    public decimal? Amount { get; set; }

    public int? SlNo { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
