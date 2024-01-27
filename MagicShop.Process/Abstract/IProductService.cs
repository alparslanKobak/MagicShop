using MagicShop.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Abstract
{
    public interface IProductService : IService<Product>
    {
        Task<List<Product>> GetProductsByIncludeAsync();
        Task<List<Product>> GetProductsByIncludeAsync(Expression <Func<Product, bool>> expression);
        Task<Product> GetProductByIncludeAsync(Guid id);
        Task<Product> GetProductByIncludeAsync(Expression<Func<Product, bool>> expression);
    }
}
