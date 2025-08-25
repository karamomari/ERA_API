﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblServiceDetail
{
    public decimal ServiceDetailsId { get; set; }

    public decimal? ServiceMasterId { get; set; }

    public decimal? ServiceId { get; set; }

    public string? Measure { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
