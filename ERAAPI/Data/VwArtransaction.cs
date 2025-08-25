using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class VwArtransaction
{
    public decimal MasterId { get; set; }

    public string? VoucherNo { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public string? VoucherTypeName { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DueDate { get; set; }

    public int? DueDay { get; set; }

    public decimal? LedgerId { get; set; }

    public string? LedgerNumber { get; set; }

    public string? LedgerName { get; set; }

    public decimal? AccountGroupId { get; set; }

    public string? AccountGroupName { get; set; }

    public string AreaName { get; set; } = null!;

    public string RouteName { get; set; } = null!;

    public string? Narration { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Status { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public decimal? CurrencyIdFun { get; set; }

    public string? CurrencyNameFun { get; set; }

    public string? CurrencyName { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? AdditionalCost { get; set; }

    public decimal? BillDiscount { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? NetAmountFun { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? DebitFun { get; set; }

    public decimal? CreditFun { get; set; }
}
