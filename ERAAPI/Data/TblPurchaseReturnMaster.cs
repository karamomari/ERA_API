using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblPurchaseReturnMaster
{
    public decimal PurchaseReturnMasterId { get; set; }

    public string? VoucherNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? SuffixPrefixId { get; set; }

    public decimal? PaymentTermId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? DueDate { get; set; }

    public string? CreditPeriod { get; set; }

    public decimal? LedgerId { get; set; }

    public string? VendorInvoiceNo { get; set; }

    public DateTime? VendorInvoiceDate { get; set; }

    public decimal? EmployeeId { get; set; }

    public string? Narration { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public decimal? FinancialYearId { get; set; }

    public decimal? UserId { get; set; }

    public decimal? PurchaseAccount { get; set; }

    public decimal? PurchaseMasterId { get; set; }

    public decimal? TaxId { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? AdditionalCost { get; set; }

    public decimal? BillDiscount { get; set; }

    public decimal? GrandTotal { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? LrNo { get; set; }

    public string? TransportationCompany { get; set; }

    public decimal? PaymentType { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? Status { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
