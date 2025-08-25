using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblProductGroup
{
    public decimal GroupId { get; set; }

    public string? GroupName { get; set; }

    public decimal? GroupUnder { get; set; }

    public string? Narration { get; set; }

    public decimal? SortOrder { get; set; }

    public string? BackColor { get; set; }

    public string? FontColor { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
