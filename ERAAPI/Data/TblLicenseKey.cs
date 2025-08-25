using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblLicenseKey
{
    public int LicenseId { get; set; }

    public string? LicenseKey { get; set; }

    public string? SecretCode { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ExpireDate { get; set; }
}
