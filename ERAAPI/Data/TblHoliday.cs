using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblHoliday
{
    public decimal HolidayId { get; set; }

    public DateTime? Date { get; set; }

    public string? HolidayName { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
