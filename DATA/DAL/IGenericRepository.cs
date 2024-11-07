using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int Id);
        Task<T> GetById(long Id);
        Task<T> GetById(Guid Id);
        Task<IEnumerable<T>> GetList();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }

}



