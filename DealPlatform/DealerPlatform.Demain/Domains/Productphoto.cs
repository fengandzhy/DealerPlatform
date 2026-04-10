using System;
using System.Collections.Generic;

namespace DealerPlatform.Demain.Domains;

public partial class Productphoto
{
    public int Id { get; set; }

    public string? SysNo { get; set; }

    public string ProductNo { get; set; } = null!;

    public string ProductPhotoUrl { get; set; } = null!;
}
