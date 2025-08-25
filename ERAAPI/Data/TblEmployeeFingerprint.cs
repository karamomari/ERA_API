using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblEmployeeFingerprint
{
    public decimal EmployeeId { get; set; }

    public byte[] FingerTemplate { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
