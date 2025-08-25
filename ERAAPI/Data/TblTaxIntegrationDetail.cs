using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblTaxIntegrationDetail
{
    public decimal TaxIntegrationDetailsId { get; set; }

    public decimal? TaxIntegrationMasterId { get; set; }

    public Guid? Id { get; set; }

    public decimal? Index { get; set; }

    public decimal? ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? NetPrice { get; set; }

    public decimal? LineDiscount { get; set; }

    public decimal? Tax { get; set; }

    public string? TaxCategory { get; set; }

    public string? CurrencyCode { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
