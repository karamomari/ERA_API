using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblWorkflowStep
{
    public decimal WorkflowStepId { get; set; }

    public decimal? ParentStepId { get; set; }

    public decimal? WorkflowId { get; set; }

    public string? StepName { get; set; }

    public string? Description { get; set; }

    public string? StepType { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
