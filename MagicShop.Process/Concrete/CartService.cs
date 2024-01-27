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
    public class CartService : Service<Cart>, ICartService
    {
        public CartService(DatabaseContext context) : base(context)
        {
        }

        public async Task<Cart> GetCartByIncludeAsync(Guid id)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.CardItems)
                .ThenInclude(x => x.Product)
                   .ThenInclude(x => x.Category)
                .FirstOrDefaultAsync(x => x.CartId == id);
        }

        public async Task<Cart> GetCartByIncludeAsync(Expression<Func<Cart, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.CardItems)
                 .ThenInclude(x => x.Product)
                    .ThenInclude(x => x.Category)
                 .FirstOrDefaultAsync(expression);
        }

        public async Task<List<Cart>> GetCartsByIncludeAsync()
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.CardItems)
                 .ThenInclude(x => x.Product)
                    .ThenInclude(x => x.Category)
                 .ToListAsync();
        }

        public async Task<List<Cart>> GetCartsByIncludeAsync(Expression<Func<Cart, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.CardItems)
                 .ThenInclude(x => x.Product)
                 .ThenInclude(x => x.Category)
                 .Where(expression)
                 .ToListAsync();
        }
    }
}
