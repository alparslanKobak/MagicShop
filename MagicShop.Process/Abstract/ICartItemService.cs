using MagicShop.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Abstract
{
    public interface ICartItemService : IService<CartItem>
    {
        Task<List<CartItem>> GetCartItemsByIncludeAsync(Guid cardId);
        Task<List<CartItem>> GetCartItemsByIncludeAsync();
        Task<List<CartItem>> GetCartItemsByIncludeAsync(Expression<Func<CartItem, bool>> expression);

        Task<CartItem> GetCartItemByIncludeAsync(Expression<Func<CartItem, bool>> expression);
        Task<CartItem> GetCartItemByIncludeAsync(Guid id);

    }
}
