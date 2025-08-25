using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblSettingsToCopy
{
    public decimal SettingsId { get; set; }

    public string? SettingsName { get; set; }

    public string? Status { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
