using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblSocialSecurityType
{
    public decimal SocialSecurityId { get; set; }

    public string? Name { get; set; }

    public string NameAr { get; set; } = null!;

    public string? Type { get; set; }

    public decimal EmployeeDeductionRate { get; set; }

    public decimal CompanyDeductionRate { get; set; }

    public string? Description { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
