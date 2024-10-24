using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tedarik.Core.Models;

namespace Tedarik.Core.Business
{
    public interface IBaseService<T> where T : class, new()
    {
        Result<T> Add(T entity);
        Result<T> Delete(string id);
        Result<T> Update(T entity);
        Result<ICollection<T>> GetAll();
        Result<T> GetById(string id);
    }
}
