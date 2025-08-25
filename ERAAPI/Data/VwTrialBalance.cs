using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class VwTrialBalance
{
    public decimal JournalMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public DateTime? Date { get; set; }

    public string? Narration { get; set; }

    public string? Status { get; set; }

    public decimal? JournalDetailsId { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal AgainstvoucherTypeId { get; set; }

    public string AgainstVoucherTypeName { get; set; } = null!;

    public string? AgainstVoucherNo { get; set; }

    public decimal? LedgerId { get; set; }

    public string? LedgerNumber { get; set; }

    public string? LedgerName { get; set; }

    public decimal? AccountGroupId { get; set; }

    public string? AccountGroupName { get; set; }

    public string? Nature { get; set; }

    public string? ReferenceNo { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public decimal? CurrencyIdFun { get; set; }

    public string? CurrencyNameFun { get; set; }

    public decimal? CurrencyId { get; set; }

    public string? CurrencyName { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? DebitFun { get; set; }

    public decimal? CreditFun { get; set; }
}
