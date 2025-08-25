﻿using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblPaymentDetail
{
    public decimal PaymentDetailsId { get; set; }

    public decimal? PaymentMasterId { get; set; }

    public decimal? LedgerId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public string? ChequeNo { get; set; }

    public DateTime? ChequeDate { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }
}
