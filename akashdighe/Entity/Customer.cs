using System;
using System.Collections.Generic;

namespace Ecomm.Entity;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Country { get; set; } = null!;
}
