using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblWorkflow
{
    public decimal Id { get; set; }

    public decimal? WorkflowId { get; set; }

    public decimal? WorkflowSequence { get; set; }

    public string? ApprovalType { get; set; }

    public decimal? VoucherType { get; set; }

    public decimal? VoucherId { get; set; }

    public decimal? UserId { get; set; }

    public decimal? EmailId { get; set; }

    public string? EmailStatus { get; set; }

    public string? WorkflowStatus { get; set; }

    public string? WorkflowComment { get; set; }

    public decimal? DelegateToUserId { get; set; }

    public bool? IsCurrent { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
