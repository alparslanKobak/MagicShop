using MagicShop.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Abstract
{
    public interface ICategoryService : IService<Category>
    {
        Task<List<Category>> GetCategoriesByIncludeAsync();
        Task<List<Category>> GetCategoriesByIncludeAsync(Expression <Func<Category, bool>> expression);
        Task<Category> GetCategoryByIncludeAsync(Guid id);
        Task<Category> GetCategoryByIncludeAsync(Expression<Func<Category, bool>> expression);
    }
}
