using System;
using System.Collections.Generic;

namespace ShopWebAPI.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Password { get; set; } = null!;
}
