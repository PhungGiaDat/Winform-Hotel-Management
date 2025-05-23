﻿using Final_Project_QLKS.Models;
using Final_Project_QLKS.Repositorys.Interfaces;
using Final_Project_QLKS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Services
{
    public class AuthorizationService : IAuthorizationService
    {

        private readonly IUserRepository _userRepository;

        public AuthorizationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool HasPermission(User user, string permissionKey)
        {
            return user?.Role?.RolePermissions
                   ?.Any(rp => rp.Permission.PermissionName == permissionKey)
                   ?? false;
        }
        public bool IsLoggedIn(User user)
        {
            return user != null && user.Role != null && user.Role.RolePermissions?.Any() == true;
        }   
    }
}