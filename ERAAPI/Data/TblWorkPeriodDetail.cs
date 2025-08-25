using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblWorkPeriodDetail
{
    public decimal WorkPeriodDetailsId { get; set; }

    public decimal? WorkPeriodId { get; set; }

    public decimal? VoucherTypeId { get; set; }

    public decimal? MasterId { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
