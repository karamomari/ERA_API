using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblPostingSetup
{
    public decimal PostingSetupId { get; set; }

    public string? PostingType { get; set; }

    public decimal? CustomerId { get; set; }

    public decimal? CustomerGroupId { get; set; }

    public decimal? VendorId { get; set; }

    public decimal? VendorGroupId { get; set; }

    public decimal? ProductId { get; set; }

    public decimal? ProductGroupId { get; set; }

    public decimal? ServiceId { get; set; }

    public decimal? ServiceCategoryId { get; set; }

    public decimal? ExpensesId { get; set; }

    public decimal? ExpensesCategoryId { get; set; }

    public decimal? BankId { get; set; }

    public decimal? GodownId { get; set; }

    public decimal? TaxId { get; set; }

    public decimal? AdditionalCostId { get; set; }

    public decimal? PostineLedgerId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
