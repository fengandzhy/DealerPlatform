using System;
using System.Collections.Generic;

namespace DealerPlatform.Demain.Domains;

public partial class Product
{
    public int Id { get; set; }

    public string SysNo { get; set; } = null!;

    public string ProductNo { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string TypeNo { get; set; } = null!;

    public string TypeName { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string Material { get; set; } = null!;

    public string Pattern { get; set; } = null!;

    public string Thickness { get; set; } = null!;

    public string Process { get; set; } = null!;

    public string ColorPattern { get; set; } = null!;

    public string SurfaceMaterial { get; set; } = null!;

    public string Grade { get; set; } = null!;

    public string Origin { get; set; } = null!;

    public string Specification { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string UnitNo { get; set; } = null!;

    public string UnitName { get; set; } = null!;

    public string ProductNote { get; set; } = null!;

    public string ProductBzgg { get; set; } = null!;

    public string BelongTypeNo { get; set; } = null!;

    public string BelongTypeName { get; set; } = null!;
}
