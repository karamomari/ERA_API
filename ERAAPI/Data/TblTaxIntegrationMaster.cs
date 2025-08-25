using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblTaxIntegrationMaster
{
    public decimal TaxIntegrationMasterId { get; set; }

    public decimal? MasterId { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public string? InvoiceNumber { get; set; }

    public decimal? InvoiceTypeCode { get; set; }

    public string? InvoiceType { get; set; }

    public string? TaxPayerType { get; set; }

    public string? PaymentMethod { get; set; }

    public Guid? Id { get; set; }

    public decimal? Order { get; set; }

    public string? SupplierSellerName { get; set; }

    public string? SupplierSellerTin { get; set; }

    public string? SupplierCountryCode { get; set; }

    public string? SupplierActivityNumber { get; set; }

    public string? CustomerCustomerName { get; set; }

    public string? CustomerIdentityNumber { get; set; }

    public string? CustomerIdentityType { get; set; }

    public string? CustomerZipCode { get; set; }

    public string? CustomerCountryCode { get; set; }

    public string? CustomerCityCode { get; set; }

    public string? CustomerTelephone { get; set; }

    public string? CurrencyCode { get; set; }

    public DateTime? IssueDate { get; set; }

    public string? Notes { get; set; }

    public string? ReferenceId { get; set; }

    public string? ReferenceUuid { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
