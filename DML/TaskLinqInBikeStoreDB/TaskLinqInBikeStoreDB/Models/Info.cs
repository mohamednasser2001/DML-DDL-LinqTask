using System;
using System.Collections.Generic;

namespace TaskLinqInBikeStoreDB.Models;

public partial class Info
{
    public string? ProductName { get; set; }

    public string BrandName { get; set; } = null!;

    public decimal ListPrice { get; set; }
}
