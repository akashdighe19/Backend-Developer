using System;
using System.Collections.Generic;

namespace Ecomm.Entity;

public partial class Order
{
    public uint Id { get; set; }

    public int? CustomerId { get; set; }

    public decimal? Amount { get; set; }
}
