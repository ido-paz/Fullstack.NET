using System;
using System.Collections.Generic;

namespace Shop_Blazor_Server.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? PhoneNumber { get; set; }
}
