using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblMonthlySalaryDetail
{
    public decimal MonthlySalaryDetailsId { get; set; }

    public decimal? EmployeeId { get; set; }

    public decimal? SalaryPackageId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? MonthlySalaryId { get; set; }
}
