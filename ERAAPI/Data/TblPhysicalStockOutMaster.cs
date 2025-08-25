﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblPhysicalStockOutMaster
{
    public decimal PhysicalStockMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? SuffixPrefixId { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public DateTime? Date { get; set; }

    public string? Narration { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? FinancialYearId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
