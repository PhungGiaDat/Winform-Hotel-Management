using Final_Project_QLKS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Repositorys
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(QlkhachsanContext context) : base(context){}

        public User ? GetByUsername(string username)
        {
            return _dbSet.FirstOrDefault(user => user.Username == username);
        }
    }
}
