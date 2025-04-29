using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_QLKS.Repositorys.Interfaces
{
    // Phương thức để dùng chung khi các truy vấn giữa các bảng trong database giống nhau 
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();
    }
}
