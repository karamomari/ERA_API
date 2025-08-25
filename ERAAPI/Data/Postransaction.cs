using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class Postransaction
{
    public decimal? Id { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? MailingName { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? Cash { get; set; }

    public decimal Visa { get; set; }

    public decimal Debit { get; set; }

    public decimal? WorkPeriodId { get; set; }
}
