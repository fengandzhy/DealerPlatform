using System;
using System.Collections.Generic;

namespace DealerPlatform.Demain.Domains;

public partial class Customerinvoice
{
    public int Id { get; set; }

    public string CustomerNo { get; set; } = null!;

    public string InvoiceNo { get; set; } = null!;

    public string InvoiceEin { get; set; } = null!;

    public string InvoiceBank { get; set; } = null!;

    public string InvoiceAccount { get; set; } = null!;

    public string InvoiceAddress { get; set; } = null!;

    public string InvoicePhone { get; set; } = null!;
}
