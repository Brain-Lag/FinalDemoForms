using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BaseRepo<T> where T : class
    {
        private AppDbContext _context = new();

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public T? Read(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = Read(id);
            if (entity == null) return;
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
