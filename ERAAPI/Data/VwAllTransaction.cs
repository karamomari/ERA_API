using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class VwAllTransaction
{
    public decimal MasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public DateTime? Date { get; set; }

    public decimal? UserId { get; set; }

    public string? Status { get; set; }
}
