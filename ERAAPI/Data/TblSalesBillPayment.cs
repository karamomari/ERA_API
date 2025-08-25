using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblSalesBillPayment
{
    public decimal SalesBillPaymentId { get; set; }

    public decimal? SalesMasterId { get; set; }

    public decimal? BankLedgerId { get; set; }

    public string? PaymentName { get; set; }

    public string? PaymentType { get; set; }

    public decimal? PaymentAmount { get; set; }

    public decimal? PayedAmount { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
