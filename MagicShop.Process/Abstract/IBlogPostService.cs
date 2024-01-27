using MagicShop.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Abstract
{
    public interface IBlogPostService : IService<BlogPost>
    {
        Task<List<BlogPost>> GetBlogPostsByIncludeAsync();
        Task<List<BlogPost>> GetBlogPostsByIncludeAsync(Expression<Func<BlogPost, bool>> expression);
        Task<BlogPost> GetBlogPostByIncludeAsync(Guid id);
        Task<BlogPost> GetBlogPostByIncludeAsync(Expression<Func<BlogPost, bool>> expression);

    }
}
