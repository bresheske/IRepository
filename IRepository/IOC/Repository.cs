using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.IOC
{
    /// <summary>
    /// Implementation of IRepository<T>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="C"></typeparam>
    public abstract class Repository<T, C> : IRepository<T>
        where T : BaseEntity
        where C : DbContext
    {

        private readonly C context;
        public Repository(C ctx)
        {
            context = ctx;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public IQueryable<T> All()
        {
            return context.Set<T>().AsQueryable();
        }

        public void Add(T item)
        {
            context.Set<T>().Add(item);
        }

        public void Remove(T item)
        {
            context.Set<T>().Remove(item);
        }

        public void Remove(int id)
        {
            var t = context.Set<T>().Find(id);
            context.Set<T>().Remove(t);
        }

        public bool Any()
        {
            return context.Set<T>().Any();
        }

        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return context.Set<T>().Any(where);
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return context.Set<T>().Where(where);
        }

        public T Single(int id)
        {
            return context.Set<T>().Find(id);
        }

        public int Count()
        {
            return context.Set<T>().Count();
        }

        public int Count(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return context.Set<T>().Count(where);
        }
    }
}
