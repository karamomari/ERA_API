using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblUser
{
    public decimal UserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool? Active { get; set; }

    public decimal? RoleId { get; set; }

    public decimal? EmployeeId { get; set; }

    public decimal? ManagerId { get; set; }

    public decimal? BankId { get; set; }

    public decimal? GodownId { get; set; }

    public string? Narration { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
