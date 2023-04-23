using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop_MVC.Models;

public partial class Product
{
    public int Id { get; set; }

    [MinLength(2)]
    [MaxLength(32)]
    [Required]
    public string Name { get; set; } = null!;

    [Required]
    [Range(1,12345)]
    public decimal Price { get; set; }
}
