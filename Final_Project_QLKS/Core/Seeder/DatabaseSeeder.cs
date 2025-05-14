using Final_Project_QLKS.Core.Constants;
using Final_Project_QLKS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Security.Policy;


namespace Final_Project_QLKS.Core.Seeding
{
    public static class DatabaseSeeder
    {
        public static void SeedOnce(QlkhachsanContext context)
        {

            var hasher = new PasswordHasher<string>();
            if (!context.Roles.Any())
            {
                var roles = new List<Role>
               {
                   new Role { RoleName = RoleKeys.Admin },
                   new Role { RoleName = RoleKeys.Manager },
                   new Role { RoleName = RoleKeys.Staff }
               };
                context.Roles.AddRange(roles);
                context.SaveChanges();
            }

            var roleMap = context.Roles.ToDictionary(r => r.RoleName, r => r.RoleId);

            if (!context.Permissions.Any())
            {
                var permissions = new List<Permission>
               {
                   new Permission { PermissionName = PermissionsKeysList.ManageUsers },
                   new Permission { PermissionName = PermissionsKeysList.ViewReports },
               };
                context.Permissions.AddRange(permissions);
                context.SaveChanges();
            }

            var permissionMap = context.Permissions.ToDictionary(p => p.PermissionName, p => p.PermissionId);

            if (!context.Role_Permissions.Any())
            {
                context.Role_Permissions.Add(new RolePermission
                {
                    RoleId = roleMap[RoleKeys.Admin],
                    PermissionId = permissionMap[PermissionsKeysList.ManageUsers]
                });
                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                var adminUser = new User
                {
                    Username = "admin",
                    RoleId = roleMap[RoleKeys.Admin],
                    Email = "admin@example.com",
                    PasswordHash = hasher.HashPassword("admin","12345678")
                };

                var managerUser = new User
                {
                    Username = "manager",
                    PasswordHash = hasher.HashPassword("manager", "manager123"),
                    Email = "manager@example.com",
                    RoleId = roleMap[RoleKeys.Manager]
                };


                context.Users.AddRange(adminUser, managerUser);
                context.SaveChanges(); // Save users
            }
        }
    }

    public static class PermissionsKeysList
    {
        public const string ManageUsers = "ManageUsers";
        public const string ViewReports = "ViewReports";
        public static readonly List<string> All = new List<string>
       {
           ManageUsers,
           ViewReports,
           "ViewRoom",
           "EditRoom",
           "CreateBooking",
           "CancelBooking",
           "ManagePayments",
           "ManageBranches"
       };
    }
}
