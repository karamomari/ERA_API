using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblMasterDataPrivilege
{
    public decimal PrivilegeId { get; set; }

    public string? MasterDataType { get; set; }

    public string? Action { get; set; }

    public decimal? UserId { get; set; }

    public decimal? MasterDataId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Exatra1 { get; set; }

    public string? Extra2 { get; set; }
}
