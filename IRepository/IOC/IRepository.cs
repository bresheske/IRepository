using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace IRepository.IOC
{
    /// <summary>
    /// The base interface which all child interfaces 
    /// must reference. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
        where T : BaseEntity
    {
        /// <summary>
        /// Saves the database context.
        /// </summary>
        void Save();

        /// <summary>
        /// Returns all entities in the set.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> All();

        /// <summary>
        /// Adds an item to the entity set.
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);
        /// <summary>
        /// Removes an item from the entity set.
        /// </summary>
        /// <param name="item"></param>
        void Remove(T item);
        /// <summary>
        /// Removes an item from the entity set.
        /// </summary>
        /// <param name="id"></param>
        void Remove(int id);

        /// <summary>
        /// Returns true if the set contains anything.
        /// </summary>
        /// <returns></returns>
        bool Any();
        /// <summary>
        /// Returns true if the set contains anything within
        /// the provided where clause.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        bool Any(Expression<Func<T, bool>> where);

        /// <summary>
        /// Returns a set of entities matching the provided
        /// where clause.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IQueryable<T> Where(Expression<Func<T, bool>> where);

        /// <summary>
        /// Returns a single entity with the given ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Single(int id);

        /// <summary>
        /// Returns the count of the set.
        /// </summary>
        /// <returns></returns>
        int Count();
        /// <summary>
        /// Returns the count of the set based on the 
        /// provided where clause.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Count(Expression<Func<T, bool>> where);
        /// <summary>
        /// FirstOrDefault Implementation.
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T Find(Expression<Func<T, bool>> where);
    }

}