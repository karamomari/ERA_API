using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblWorkflowStepAssignment
{
    public decimal StepAssignmentId { get; set; }

    public decimal? WorkflowStepId { get; set; }

    public decimal? AssignmentOrder { get; set; }

    public string? AssignmentType { get; set; }

    public decimal? AssignmentId { get; set; }

    public string? ActionType { get; set; }

    public decimal? EmailId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
