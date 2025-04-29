using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Role
{
    public Role()
    {
        Users = new HashSet<User>();
        RolePermissions = new HashSet<RolePermission>();
    }

    public int RoleId { get; set; }
    public string RoleName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; }
    public virtual ICollection<RolePermission> RolePermissions { get; set; }

    // Không cần map với EF - chỉ để truy cập thuận tiện
    public ICollection<Permission> Permissions => RolePermissions.Select(rp => rp.Permission).ToList();
}
