using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblWorkflowSetup
{
    public decimal WorkflowId { get; set; }

    public string? WorkflowName { get; set; }

    public string? Description { get; set; }

    public decimal? VoucherType { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
