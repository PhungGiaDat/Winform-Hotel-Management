using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int RoleId { get; set; }

    public int? BranchId { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Role Role { get; set; } = null!;
}
