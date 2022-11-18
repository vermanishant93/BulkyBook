using System;
using System.Linq.Expressions;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
        // To Delete Multiple Items: Collection of Entities will be passed here
        void RemoveRange(IEnumerable<T> entity);
    }
}

