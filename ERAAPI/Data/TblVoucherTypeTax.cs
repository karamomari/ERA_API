using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblVoucherTypeTax
{
    public decimal VoucherTypeTaxId { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? TaxId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
