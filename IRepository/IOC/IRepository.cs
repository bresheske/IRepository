using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace IRepository.IOC
{
    public interface IRepository<T>
        where T : BaseEntity
    {
        void Save();

        void Add(T item);
        void Remove(T item);
        void Remove(int id);

        bool Any();
        bool Any(Expression<Func<T, bool>> where);

        IQueryable<T> Where(Expression<Func<T, bool>> where);

        T Single(int id);

        int Count();
        int Count(Expression<Func<T, bool>> where);
    }

}