using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class VwTax
{
    public decimal MasterId { get; set; }

    public decimal? DetailsId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public string VoucherTypeName { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string? LedgerNumber { get; set; }

    public string? LedgerName { get; set; }

    public string? AccountGroupName { get; set; }

    public decimal? TaxableAmount { get; set; }

    public decimal? TaxId { get; set; }

    public string? TaxName { get; set; }

    public decimal? Rate { get; set; }

    public decimal? TaxAmount { get; set; }

    public string? Status { get; set; }
}
