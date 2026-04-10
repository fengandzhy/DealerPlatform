using System;
using System.Collections.Generic;

namespace DealerPlatform.Demain.Domains;

public partial class Productsaleareadiff
{
    public int Id { get; set; }

    public string SysNo { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public string StockNo { get; set; } = null!;

    public string AreaNo { get; set; } = null!;

    public string FirstAreaNo { get; set; } = null!;

    public double DiffPrice { get; set; }
}
