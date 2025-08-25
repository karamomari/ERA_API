using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class EraPosEmployeeSalarySummary
{
    public decimal EmployeeId { get; set; }

    public string? EmployeeCode { get; set; }

    public string? EmployeeName { get; set; }

    public decimal? MonthlyWage { get; set; }

    public string? SalaryPackageName { get; set; }

    public decimal? PackageAmount { get; set; }

    public decimal? BaseSalaryBonus { get; set; }

    public decimal? PrivateBonus { get; set; }

    public string? GeneralBonus { get; set; }

    public decimal? PrivateDeduction { get; set; }

    public string? GeneralDeduction { get; set; }
}
