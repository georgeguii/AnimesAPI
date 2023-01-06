using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace AnimesAPI.DAL.DAO.BaseDAO
{
    public class BaseDAO<T> : IDAO<T> where T : class
    {
        private readonly AnimesDbContext _context;

        public BaseDAO(AnimesDbContext context)
        {
            _context = context;
        }

        public virtual T Create(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();

            return obj;
        }

        public virtual async Task<IEnumerable<T>> Get() 
            => await _context.Set<T>().ToListAsync();

        public virtual async Task<T> GetOne(long id)
            => await _context.Set<T>().FindAsync(id);

        public virtual async Task<T> GetOne(string valor)
            => await _context.Set<T>().FindAsync(valor);

        public virtual T Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();

            return obj;
        }

        public virtual void Delete(T obj, bool save = true)
        {
            if (obj != null)
            {
                _context.Remove(obj);

                if (save)
                {
                    _context.SaveChanges();
                }
            }
        }

        public virtual void Delete(long id, bool save = true)
        {
            var obj = _context.Set<T>().Find(id);

            if (obj != null)
            {
                _context.Remove(obj);
                if (save)
                {
                    _context.SaveChanges();
                }
            }
        }

        public virtual void Delete(string valor, bool save = true)
        {
            var obj = _context.Set<T>().Find(valor);
            if (obj != null)
            {
                _context.Set<T>().Remove(obj);
                if (save)
                {
                    _context.SaveChanges();
                }
            }
        }

    }
}
