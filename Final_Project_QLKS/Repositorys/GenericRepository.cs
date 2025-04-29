using Final_Project_QLKS.Repositorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project_QLKS.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project_QLKS.Repositorys
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly QlkhachsanContext _context;
        protected readonly DbSet<T> _dbSet;
        public GenericRepository(QlkhachsanContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            Save();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            Save();
        }
        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                Save();
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }

}
