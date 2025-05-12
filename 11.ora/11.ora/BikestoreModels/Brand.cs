﻿using System;
using System.Collections.Generic;

namespace _11.ora.BikestoreModels;

public partial class Brand
{
    public int BrandSk { get; set; }

    public string BrandName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
