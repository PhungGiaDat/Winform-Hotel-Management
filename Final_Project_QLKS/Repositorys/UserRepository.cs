using Final_Project_QLKS.Models;
using Final_Project_QLKS.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Repositorys
{
    public class UserRepository : GenericRepository<User>,IUserRepository
    {
        public UserRepository(QlkhachsanContext context) : base(context){}

        public User ? GetByUsername(string username)
        {
            return _dbSet.FirstOrDefault(user => user.Username == username);
        }
        public User? GetWithRoleAndPermissions(string username)
        {
            return _dbSet
                .Include(user => user.Role)
                    .ThenInclude(role => role.RolePermissions)
                        .ThenInclude(rp => rp.Permission)
                .FirstOrDefault(user => user.Username == username);
        }
    }
}
    