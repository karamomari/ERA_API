using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblDepartment
{
    public decimal DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public string? DepartmentCode { get; set; }

    public string? Phone { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Narration { get; set; }
}
