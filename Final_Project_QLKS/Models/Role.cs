using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Role
{
    public Role()
    {
        Users = new HashSet<User>();
        Permissions = new HashSet<Permission>();
    }


    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
