using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblFormActionType
{
    public decimal ActionId { get; set; }

    public string? ActionType { get; set; }

    public string? Action { get; set; }

    public string? ActionName { get; set; }

    public string? ActionNameAr { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
