﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblAccountGroupToCopy
{
    public decimal AccountGroupId { get; set; }

    public string? AccountGroupName { get; set; }

    public decimal? GroupUnder { get; set; }

    public string? Narration { get; set; }

    public bool? IsDefault { get; set; }

    public string? Nature { get; set; }

    public bool? AffectGrossProfit { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
