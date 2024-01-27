using MagicShop.Kernel.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Abstract
{
    public interface IService<T> where T : class
    {
        Task<T> FindAsync(Guid id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);

        Task<bool> UpdateAsync(T entity, Guid id);
        Task<bool> SoftDeleteAsync(Guid id);
    }
}
