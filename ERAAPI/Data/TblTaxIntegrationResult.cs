using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblTaxIntegrationResult
{
    public decimal TaxIntegrationResultId { get; set; }

    public decimal? TaxIntegrationMasterId { get; set; }

    public string? Status { get; set; }

    public string? SingedInvoice { get; set; }

    public string? InvoiceQr { get; set; }

    public string? InvoiceQrbase64String { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? InvoiceUuid { get; set; }

    public string? InvoiceXml { get; set; }

    public string? SingedInvoiceXml { get; set; }

    public string? InvoiceErrors { get; set; }

    public string? InvoiceWarnings { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
