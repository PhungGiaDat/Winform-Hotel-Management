using Final_Project_QLKS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Services.Interfaces
{
    public interface IAuthorizationService
    {
        bool HasPermission(User user, string permissionsKey);
        bool IsLoggedIn(User user);
    }
}
