using System;
using System.Collections.Generic;

namespace Final_Project_QLKS.Models;

public partial class Permission
{
    public int PermissionId { get; set; }

    public string PermissionName { get; set; } = null!;
    public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    public ICollection<Role> Roles => RolePermissions.Select(rp => rp.Role).ToList();

}
