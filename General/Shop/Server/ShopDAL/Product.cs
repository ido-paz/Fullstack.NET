using System;
using System.Collections.Generic;

namespace ShopDAL;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string? ImageName { get; set; }

    public string? ImageData { get; set; }
    
}
