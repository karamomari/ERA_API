using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblAttachment
{
    public decimal AttachmentId { get; set; }

    public string? AttachmentName { get; set; }

    public string? AttachmentType { get; set; }

    public decimal? AttachmentSize { get; set; }

    public string? AttachmentContentBase64 { get; set; }

    public string? AttachmentSourceType { get; set; }

    public decimal? AttachmentSourceId { get; set; }

    public bool? Active { get; set; }

    public decimal? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public decimal? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
