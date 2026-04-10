using System;
using System.Collections.Generic;

namespace DealerPlatform.Demain.Domains;

public partial class Saleorderprogress
{
    public int Id { get; set; }

    public string SaleOrderNo { get; set; } = null!;

    public string ProgressGuid { get; set; } = null!;

    public int StepSn { get; set; }

    public string StepName { get; set; } = null!;

    public DateTime StepTime { get; set; }
}
