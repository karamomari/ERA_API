using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblGodown
{
    public decimal GodownId { get; set; }

    public string? GodownName { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
