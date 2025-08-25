﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblDailyAttendanceDetail
{
    public decimal DailyAttendanceDetailsId { get; set; }

    public decimal? DailyAttendanceMasterId { get; set; }

    public decimal? EmployeeId { get; set; }

    public string? Status { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
