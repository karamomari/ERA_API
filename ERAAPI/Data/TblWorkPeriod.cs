using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblWorkPeriod
{
    public decimal WorkPeriodId { get; set; }

    public decimal? UserId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public decimal? CashDeclaration { get; set; }

    public string? Register { get; set; }

    public string? UserDefined1 { get; set; }

    public int? UserDefined2 { get; set; }

    public bool? Closed { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
