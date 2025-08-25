using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblSystemLog
{
    public decimal Id { get; set; }

    public string? Name { get; set; }

    public string? Narration { get; set; }

    public string? Type { get; set; }

    public decimal? UserId { get; set; }

    public string? Form { get; set; }

    public string? Source { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
