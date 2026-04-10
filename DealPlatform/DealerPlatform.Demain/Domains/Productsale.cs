using System;
using System.Collections.Generic;

namespace DealerPlatform.Demain.Domains;

public partial class Productsale
{
    public int Id { get; set; }

    public string SysNo { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public string? StockNo { get; set; }

    public double SalePrice { get; set; }
}
