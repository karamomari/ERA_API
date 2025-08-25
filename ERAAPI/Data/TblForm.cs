using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblForm
{
    public decimal FormId { get; set; }

    public decimal? ParentFormId { get; set; }

    public int? FormOrder { get; set; }

    public string? FormModule { get; set; }

    public string? FormType { get; set; }

    public string? FormName { get; set; }

    public string? FormModuleAr { get; set; }

    public string? FormTypeAr { get; set; }

    public string? FormNameAr { get; set; }

    public string? ActionType { get; set; }

    public string? Licence { get; set; }

    public string? FormLink { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
