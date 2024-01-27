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
    public class BlogPostService : Service<BlogPost>, IBlogPostService
    {
        public BlogPostService(DatabaseContext context) : base(context)
        {
        }

        public async Task<BlogPost> GetBlogPostByIncludeAsync(Guid id)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Comments)
                .ThenInclude(x => x.AppUser)
                .FirstOrDefaultAsync(x => x.BlogPostId == id);
        }

        public async Task<BlogPost> GetBlogPostByIncludeAsync(Expression<Func<BlogPost, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Comments)
                .ThenInclude(x => x.AppUser)
                .FirstOrDefaultAsync(expression);
        }

        public async Task<List<BlogPost>> GetBlogPostsByIncludeAsync()
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Comments)
                .ThenInclude(x => x.AppUser)
                .ToListAsync();
        }

        public async Task<List<BlogPost>> GetBlogPostsByIncludeAsync(Expression<Func<BlogPost, bool>> expression)
        {
           return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Comments)
                .ThenInclude(x=> x.AppUser)
                .Where(expression)
                .ToListAsync();
        }
    }
}
