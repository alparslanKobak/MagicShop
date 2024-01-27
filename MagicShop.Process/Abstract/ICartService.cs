using MagicShop.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Abstract
{
    public interface ICartService : IService<Cart>
    {
        Task<Cart> GetCartByIncludeAsync(Guid id);
        Task<Cart> GetCartByIncludeAsync(Expression<Func<Cart,bool>> expression);
        Task<List<Cart>> GetCartsByIncludeAsync();
        Task<List<Cart>> GetCartsByIncludeAsync(Expression<Func<Cart, bool>> expression);
    }
}
