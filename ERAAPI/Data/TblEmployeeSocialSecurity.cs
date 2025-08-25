using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblEmployeeSocialSecurity
{
    public decimal EmployeeSocialSecurityId { get; set; }

    public decimal EmployeeId { get; set; }

    public decimal SocialSecurityId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
