using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblAttendance
{
    public decimal AttendanceId { get; set; }

    public decimal EmployeeId { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly? TimeIn { get; set; }

    public TimeOnly? TimeOut { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual TblEmployee Employee { get; set; } = null!;
}
