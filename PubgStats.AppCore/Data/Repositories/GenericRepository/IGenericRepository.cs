using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PubgStats.AppCore.Data.Repositories.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task Save();
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetByQuery(Expression<Func<T, bool>> query);
    }
}
