using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblStockPosting1
{
    public decimal StockPostingId { get; set; }

    public DateTime? Date { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? MasterId { get; set; }

    public decimal? DetailsId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? ProductId { get; set; }

    public decimal? BatchId { get; set; }

    public string? BatchNo { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? UnitConversionId { get; set; }

    public decimal? GodownId { get; set; }

    public decimal? RackId { get; set; }

    public decimal? AgainstVoucherTypeId { get; set; }

    public string? AgainstInvoiceNo { get; set; }

    public string? AgainstVoucherNo { get; set; }

    public decimal? InwardAllocatedQty { get; set; }

    public decimal? InwardQty { get; set; }

    public decimal? OutwardAllocatedQty { get; set; }

    public decimal? OutwardQty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? FinancialYearId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
