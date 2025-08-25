using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblSection
{
    public decimal SectionId { get; set; }

    public string SectionName { get; set; } = null!;

    public string? SectionCode { get; set; }

    public string? Phone { get; set; }

    public decimal? DepartmentId { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Narration { get; set; }
}
