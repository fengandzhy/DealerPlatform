using System;
using System.Collections.Generic;

namespace DealerPlatform.Demain.Domains;

public partial class Customerpwd
{
    public int Id { get; set; }

    public string CustomerNo { get; set; } = null!;

    public string CustomerPwd { get; set; } = null!;
}
