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
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(DatabaseContext context) : base(context)
        {
        }

        public async Task<Product> GetProductByIncludeAsync(Guid id)
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.Category)
                 .FirstOrDefaultAsync(x => x.ProductId == id);
        }

        public async Task<Product> GetProductByIncludeAsync(Expression<Func<Product, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.Category)
                 .FirstOrDefaultAsync(expression);
        }

        public async Task<List<Product>> GetProductsByIncludeAsync()
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.Category)
                 .ToListAsync();
        }

        public async Task<List<Product>> GetProductsByIncludeAsync(Expression<Func<Product, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.Category)
                 .Where(expression)
                 .ToListAsync();
        }
    }
}
