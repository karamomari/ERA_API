using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblExpensesDetail
{
    public decimal ExpensesDetailsId { get; set; }

    public decimal? ExpensesMasterId { get; set; }

    public decimal? ExpensesId { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? CostRate { get; set; }

    public string? Unit { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? UnitConversionId { get; set; }

    public bool? IsDiscountPercentage { get; set; }

    public decimal? Discount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? TaxId { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? Amount { get; set; }

    public int? SlNo { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
