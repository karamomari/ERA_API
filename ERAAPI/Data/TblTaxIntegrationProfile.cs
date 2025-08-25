using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblTaxIntegrationProfile
{
    public decimal TaxIntegrationProfileId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }

    public string? ActivityNumber { get; set; }

    public string? Tin { get; set; }

    public string? Apiurl { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public DateTime? ExtraDate { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
