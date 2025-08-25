using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class VwStock
{
    public decimal? MasterId { get; set; }

    public decimal? DetailsId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public string? VoucherTypeName { get; set; }

    public string LedgerName { get; set; } = null!;

    public decimal? ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public decimal? GroupId { get; set; }

    public string? GroupName { get; set; }

    public decimal? GodownId { get; set; }

    public string? GodownName { get; set; }

    public DateTime? Date { get; set; }

    public decimal? ConversionRate { get; set; }

    public decimal? BatchId { get; set; }

    public string? BatchNo { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal? Rate { get; set; }

    public string? UnitName { get; set; }

    public decimal? InwardAllocatedQty { get; set; }

    public decimal? InwardQty { get; set; }

    public decimal? OutwardAllocatedQty { get; set; }

    public decimal? OutwardQty { get; set; }

    public decimal? RateMainUom { get; set; }

    public string? MainUom { get; set; }

    public decimal? InwardAllocatedQtyMain { get; set; }

    public decimal? InwardQtyMain { get; set; }

    public decimal? OutwardAllocatedQtyMain { get; set; }

    public decimal? OutwardQtyMain { get; set; }

    public int Status { get; set; }
}
