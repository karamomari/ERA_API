using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblBatch
{
    public decimal BatchId { get; set; }

    public string? BatchNo { get; set; }

    public decimal? ProductId { get; set; }

    public string? Barcode { get; set; }

    public string? PartNo { get; set; }

    public DateTime? ManufacturingDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public decimal? Rate { get; set; }

    public decimal? RateMain { get; set; }

    public string? Narration { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
