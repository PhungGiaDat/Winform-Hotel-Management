using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project_QLKS.Models;



namespace Final_Project_QLKS.Services
{
    public class RoleServices
    {
        private readonly QlkhachsanContext _context;


        public RoleServices(QlkhachsanContext context)
        {
            _context = context;
        }

        public List<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }

        public Role GetRoleById(int id)
        {
            return _context.Roles.Find(id);
        }

        public void AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }


        public void DeleteRole(int id)
        {
            var role = _context.Roles.Find(id);
            if (role != null)
            {
                _context.Roles.Remove(role);
                _context.SaveChanges();
            }
        }

    }
}
