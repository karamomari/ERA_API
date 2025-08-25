using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblSmtpsetting
{
    public string? Host { get; set; }

    public int? Port { get; set; }

    public string? Security { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public bool? EnableSsl { get; set; }

    public DateTime? ExtraDate { get; set; }

    public string? Extra1 { get; set; }

    public string? Extra2 { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
