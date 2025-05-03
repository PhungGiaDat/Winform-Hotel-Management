using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project_QLKS.Models;

namespace Final_Project_QLKS.Core
{
    public static class AppState
    {
        public static User? CurrentUser { get; set; }
        public static bool IsLoggedIn => CurrentUser != null;

        public static bool IsAdmin => CurrentUser?.Role?.RoleName == RoleKeys.Admin;

        public static bool IsUser => CurrentUser?.Role?.RoleName == RoleKeys.User;

        public static bool IsManager => CurrentUser?.Role?.RoleName == RoleKeys.Manager;

        public static void Login(User user)
        {
            CurrentUser = user ?? throw new ArgumentNullException(nameof(user),"Vui lòng đăng nhập");
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
