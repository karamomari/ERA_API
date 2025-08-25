using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblReminder
{
    public decimal ReminderId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? RemindAbout { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }
}
