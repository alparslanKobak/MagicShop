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
    public class CommentService : Service<Comment>, ICommentService
    {
        public CommentService(DatabaseContext context) : base(context)
        {
        }

        public async Task<Comment> GetCommentByIncludeAsync(Guid id)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.AppUser)
                .FirstOrDefaultAsync(x => x.CommentId == id);
        }

        public async Task<Comment> GetCommentByIncludeAsync(Expression<Func<Comment, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.AppUser)
                .FirstOrDefaultAsync(expression);
        }

        public async Task<List<Comment>> GetCommentsByIncludeAsync()
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.AppUser)
                .ToListAsync();
        }

        public async Task<List<Comment>> GetCommentsByIncludeAsync(Expression<Func<Comment, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.AppUser)
                .Where(expression)
                .ToListAsync();
        }
    }
}
