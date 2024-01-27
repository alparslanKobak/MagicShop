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
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(DatabaseContext context) : base(context)
        {

        }

        public async Task<List<Category>> GetCategoriesByIncludeAsync()
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Products)
                .ToListAsync();
        }

        public async Task<List<Category>> GetCategoriesByIncludeAsync(Expression<Func<Category, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Products)
                .Where(expression)
                .ToListAsync();
        }

        public async Task<Category> GetCategoryByIncludeAsync(Guid id)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Products)
                .FirstOrDefaultAsync(x => x.CategoryId == id);
        }

        public async Task<Category> GetCategoryByIncludeAsync(Expression<Func<Category, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Products)
                .FirstOrDefaultAsync(expression);
        }
    }
    
}
