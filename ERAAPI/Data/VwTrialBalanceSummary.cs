using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class VwTrialBalanceSummary
{
    public string? AccountNumber { get; set; }

    public string? AccountName { get; set; }

    public string? AccountGroup { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Balance { get; set; }
}
