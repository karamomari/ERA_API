﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblEmployee
{
    public decimal EmployeeId { get; set; }

    public decimal? DesignationId { get; set; }

    public string? EmployeeName { get; set; }

    public string? EmployeeCode { get; set; }

    public decimal? SocialSecurityId { get; set; }

    public decimal? DefaultPackageId { get; set; }

    public DateTime? Dob { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Gender { get; set; }

    public string? Qualification { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? MobileNumber { get; set; }

    public string? Email { get; set; }

    public DateTime? JoiningDate { get; set; }

    public DateTime? TerminationDate { get; set; }

    public bool? IsActive { get; set; }

    public string? Narration { get; set; }

    public string? BloodGroup { get; set; }

    public string? PassportNo { get; set; }

    public DateTime? PassportExpiryDate { get; set; }

    public string? LabourCardNumber { get; set; }

    public DateTime? LabourCardExpiryDate { get; set; }

    public string? VisaNumber { get; set; }

    public DateTime? VisaExpiryDate { get; set; }

    public string? SalaryType { get; set; }

    public decimal? DailyWage { get; set; }

    public decimal? MonthlyWage { get; set; }

    public string? BankName { get; set; }

    public string? BranchName { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? BranchCode { get; set; }

    public string? PanNumber { get; set; }

    public string? PfNumber { get; set; }

    public string? EsiNumber { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? ManagerId { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<TblAttendance> TblAttendances { get; set; } = new List<TblAttendance>();
}
