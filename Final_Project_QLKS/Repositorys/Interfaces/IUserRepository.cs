using Final_Project_QLKS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Repositorys.Interfaces
{
    public interface IUserRepository :  IGenericRepository<User>
    {
        User? GetByUsername(string username);
        User? GetWithRoleAndPermissions(string username);
    }
}
