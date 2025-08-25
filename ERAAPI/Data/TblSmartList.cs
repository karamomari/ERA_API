using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblSmartList
{
    public int ViewId { get; set; }

    public string Caption { get; set; } = null!;

    public string StrSelect { get; set; } = null!;

    public int Parent { get; set; }

    public string FilterString { get; set; } = null!;

    public int ReportType { get; set; }

    public byte[]? ReportFile { get; set; }
}
