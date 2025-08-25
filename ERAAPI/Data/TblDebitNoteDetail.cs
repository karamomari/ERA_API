using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblDebitNoteDetail
{
    public decimal DebitNoteDetailsId { get; set; }

    public decimal? DebitNoteMasterId { get; set; }

    public decimal? LedgerId { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Debit { get; set; }

    public decimal? ExchangeRateId { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime? ReferenceDate { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
