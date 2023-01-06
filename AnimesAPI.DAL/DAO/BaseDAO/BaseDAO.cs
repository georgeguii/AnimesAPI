using Microsoft.EntityFrameworkCore;

namespace AnimesAPI.DAL.DAO.BaseDAO
{
    public class BaseDAO<T> : IDAO<T> where T : class
    {
        public AnimesDbContext _context { get; set; }

        public BaseDAO()
        {
            _context = new AnimesDbContext();
        }

        public virtual T Create(T obj)
        {
            using (_context = new AnimesDbContext())
            {
                _context.Add(obj);
                _context.SaveChanges();

                return obj;
            }
        }

        public virtual IEnumerable<T> Get()
        {
            return _context.Set<T>();
        }

        public virtual T GetOne(long id)
        {
            using (_context = new AnimesDbContext())
            {
                var obj = _context.Set<T>().Find(id);
                if (obj == null)
                {
                    throw new OperationCanceledException("Não foi possível encontrar um objeto com este Id");
                }
                return obj;
            }
        }

        public virtual T GetOne(string valor)
        {
            using (_context = new AnimesDbContext())
            {
                var obj = _context.Set<T>().Find(valor);
                if (obj == null)
                {
                    throw new OperationCanceledException("Não foi possível encontrar um objeto com esta string");
                }
                return obj;
            }
        }

        public virtual T Update(T obj)
        {
            using (_context = new AnimesDbContext())
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();

                return obj;
            }

        }

        public virtual void Delete(T obj, bool save = true)
        {
            using (_context = new AnimesDbContext())
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
        }

        public virtual void Delete(long id, bool save = true)
        {
            using (_context = new AnimesDbContext())
            {
                var obj = GetOne(id);

                if (obj != null)
                {
                    _context.Remove(obj);
                    if (save)
                    {
                        _context.SaveChanges();
                    }
                }
            }
        }

        public virtual void Delete(string valor, bool save = true)
        {
            using (_context = new AnimesDbContext())
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
}
