using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Core.Models;

namespace Tedarik.Core.DataAccess.Repository
{
    public interface IRepository<T> where T : class, new()
    {
        Result<T> GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true);
        //Task<Result<T>> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true);
        Result<ICollection<T>> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        //Task<Result<IEnumerable<T>>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        Result<T> Add(T entity);
        Task<Result<T>> AddAsync(T entity);
        Result<T> Remove(T entity);
        // Task<Result<T>> RemoveAsync(T entity);
        Result<IEnumerable<T>> RemoveRange(IEnumerable<T> entity);
        //Task<Result<IEnumerable<T>>> RemoveRangeAsync(IEnumerable<T> entity);
        Result<T> Update(T entity);
        //Task<Result<T>> UpdateAsync(T entity);
    }
}
