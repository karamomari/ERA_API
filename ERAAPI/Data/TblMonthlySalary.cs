﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblMonthlySalary
{
    public decimal MonthlySalaryId { get; set; }

    public DateTime? SalaryMonth { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
