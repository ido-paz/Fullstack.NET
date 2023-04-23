using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shop_MVC.Models;

public partial class User
{
    public int UserId { get; set; }

    [Required]
    [MinLength(2)]
    [MaxLength(16)]
    [DisplayName("User name")]
    public string UserName { get; set; } = null!;

    [MinLength(9)]
    [MaxLength(12)]
    [DisplayName("Phone number")]
    public string? PhoneNumber { get; set; }
}
