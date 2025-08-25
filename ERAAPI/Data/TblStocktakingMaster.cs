﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblStocktakingMaster
{
    public decimal StocktakingMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? SuffixPrefixId { get; set; }

    public DateTime? Date { get; set; }

    public decimal? FromGodownId { get; set; }

    public decimal? EmployeeId { get; set; }

    public string? Narration { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public decimal? FinancialYearId { get; set; }

    public decimal? UserId { get; set; }

    public decimal? AdditionalCost { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? LrNo { get; set; }

    public string? TransportationCompany { get; set; }

    public string? Status { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
