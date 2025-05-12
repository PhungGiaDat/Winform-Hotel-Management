using Final_Project_QLKS.Core.Constants;
using Final_Project_QLKS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace Final_Project_QLKS.Core.Seeding
{
    public static class DatabaseSeeder
    {

       
        public static void SeedOnce(QlkhachsanContext context)
        {
            var hasher = new PasswordHasher<string>();

            if (context.Roles.Any() || context.Permissions.Any() || context.Users.Any()) return;

            // === Seed Roles ===  
            var roles = new List<Role>
            {
                new Role { RoleName = RoleKeys.Admin },
                new Role { RoleName = RoleKeys.Manager },
                new Role { RoleName = RoleKeys.Staff },
                new Role { RoleName = RoleKeys.User }
            };
            context.Roles.AddRange(roles);
            context.SaveChanges(); // Save roles to generate Role IDs

            // === Seed Permissions ===  
            var permissions = new List<Permission>
            {
                new Permission { PermissionName = PermissionsKeys.ViewRoom },
                new Permission { PermissionName = PermissionsKeys.EditRoom },
                new Permission { PermissionName = PermissionsKeys.ManageUsers },
                new Permission { PermissionName = PermissionsKeys.CreateBooking },
                new Permission { PermissionName = PermissionsKeys.CancelBooking },
                new Permission { PermissionName = PermissionsKeys.ViewReports },
                new Permission { PermissionName = PermissionsKeys.ManagePayments },
                new Permission { PermissionName = PermissionsKeys.ManageBranches }
            };
            context.Permissions.AddRange(permissions);
            context.SaveChanges(); // Save permissions to generate Permission IDs

            // === Seed RolePermissions ===  
            var roleMap = context.Roles.ToDictionary(r => r.RoleName, r => r.RoleId);
            var permMap = context.Permissions.ToDictionary(p => p.PermissionName, p => p.PermissionId);

            var rolePerms = new List<RolePermission>();

            // Admin gets all permissions
            foreach (var permissionName in PermissionsKeysList.All)
            {
                rolePerms.Add(new RolePermission
                {
                    RoleId = roleMap[RoleKeys.Admin],
                    PermissionId = permMap[permissionName]
                });
            }

            // Manager gets specific permissions
            var managerPerms = new[]
            {
                PermissionsKeys.ViewRoom,
                PermissionsKeys.EditRoom,
                PermissionsKeys.CreateBooking,
                PermissionsKeys.ViewReports
            };

            foreach (var permissionName in managerPerms)
            {
                rolePerms.Add(new RolePermission
                {
                    RoleId = roleMap[RoleKeys.Manager],
                    PermissionId = permMap[permissionName]
                });
            }

            context.AddRange(rolePerms);
            context.SaveChanges(); // Save RolePermissions

            // === Seed First Admin and Manager Users ===  
            var adminUser = new User
            {
                Username = "admin",
                PasswordHash = hasher.HashPassword("admin","admin123"), // Use a secure password hashing library
                Email = "admin@example.com",
                RoleId = roleMap[RoleKeys.Admin]
            };  

            var managerUser = new User
            {
                Username = "manager",
                PasswordHash = hasher.HashPassword("manager","manager123"), // cần thêm giá trị username để so sánh
                Email = "manager@example.com",
                RoleId = roleMap[RoleKeys.Manager]
            };

            context.Users.AddRange(adminUser, managerUser);
            context.SaveChanges(); // Save users
        }
    }

    // Helper class to group all permissions for easier maintenance
    public static class PermissionsKeysList
    {
        public static readonly List<string> All = new List<string>
        {
            PermissionsKeys.ViewRoom,
            PermissionsKeys.EditRoom,
            PermissionsKeys.ManageUsers,
            PermissionsKeys.CreateBooking,
            PermissionsKeys.CancelBooking,
            PermissionsKeys.ViewReports,
            PermissionsKeys.ManagePayments,
            PermissionsKeys.ManageBranches
        };
    }
}
