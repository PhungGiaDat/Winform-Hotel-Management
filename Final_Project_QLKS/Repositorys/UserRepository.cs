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
            // Dùng include của Entity Framework để lấy thông tin Role và Permissions liên quan đến User
            return _dbSet.Include(user => user.Role)
                          .ThenInclude(rp => rp.Permissions)
                          .FirstOrDefault(user => user.Username == username);// trả về user có username tương ứng ngược lại trả về null
        }
    }
}
    