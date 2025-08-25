using System;
using System.Collections.Generic;

namespace ERAAPI.Data;

public partial class TblStockStaging
{
    public decimal? Id { get; set; }

    public decimal? UserId { get; set; }

    public decimal? ProductId { get; set; }

    public decimal? BatchId { get; set; }

    public decimal? UnitId { get; set; }

    public decimal? UnitConversionId { get; set; }

    public decimal? GodownId { get; set; }

    public decimal? RackId { get; set; }

    public decimal? Qty { get; set; }
}
