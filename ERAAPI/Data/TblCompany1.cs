using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblCompany1
{
    public decimal CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? MailingName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? EmailId { get; set; }

    public string? Web { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? Pin { get; set; }

    public decimal? CurrencyId { get; set; }

    public DateTime? FinancialYearFrom { get; set; }

    public DateTime? BooksBeginingFrom { get; set; }

    public string? Tin { get; set; }

    public string? Cst { get; set; }

    public string? Pan { get; set; }

    public DateTime? CurrentDate { get; set; }

    public string? Logo { get; set; }

    public byte[]? LogoImage { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
