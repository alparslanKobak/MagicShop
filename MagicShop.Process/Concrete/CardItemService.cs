using MagicShop.Business;
using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Concrete
{
    public class CardItemService : Service<CartItem>, ICartItemService
    {
        public CardItemService(DatabaseContext context) : base(context)
        {
        }

        public async Task<CartItem> GetCartItemByIncludeAsync(Expression<Func<CartItem, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Product)
                .ThenInclude(x => x.Category)
                .FirstOrDefaultAsync(expression);
        }

        public async Task<CartItem> GetCartItemByIncludeAsync(Guid id)
        {
           return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Product)
                .ThenInclude(x => x.Category)
                .FirstOrDefaultAsync(x => x.CartItemId == id);
        }

        public async Task<List<CartItem>> GetCartItemsByIncludeAsync(Guid cardId)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Product)
                .ThenInclude(x => x.Category)
                .Where(x=> x.CartId == cardId)
                .ToListAsync();
        }

        public async Task<List<CartItem>> GetCartItemsByIncludeAsync()
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Product)
                .ThenInclude(x => x.Category)
                .ToListAsync();
        }

        public async Task<List<CartItem>> GetCartItemsByIncludeAsync(Expression<Func<CartItem, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Product)
                .ThenInclude(x=> x.Category)
                .Where(expression)
                .ToListAsync();
        }
    }
}
