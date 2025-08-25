using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblWorkflowStepCondition
{
    public decimal StepConditionId { get; set; }

    public decimal? WorkflowStepId { get; set; }

    public string? Operation { get; set; }

    public string? FieldName { get; set; }

    public string? FieldType { get; set; }

    public string? Condition { get; set; }

    public string? Value { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
