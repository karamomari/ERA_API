﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblCompanyPath
{
    public decimal CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyPath { get; set; }

    public bool? IsDefault { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
