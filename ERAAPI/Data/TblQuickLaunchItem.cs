using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblQuickLaunchItem
{
    public decimal QuickLaunchItemsId { get; set; }

    public string? ItemsName { get; set; }

    public bool? Status { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }
}
