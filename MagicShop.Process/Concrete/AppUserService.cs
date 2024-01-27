using MagicShop.Business;
using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Concrete
{
    public class AppUserService : Service<AppUser>, IAppUserService
    {
        public AppUserService(DatabaseContext context) : base(context)
        {
        }

        public async Task<AppUser> GetAppUserByIncludeAsync(Guid id)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x=> x.Carts)
                .ThenInclude(x=> x.CardItems)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Category)
                .Include(x=> x.Comments)
                .FirstOrDefaultAsync(x => x.AppUserId == id);
        }

        public async Task<AppUser> GetAppUserByIncludeAsync(Expression<Func<AppUser, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Carts)
                .ThenInclude(x => x.CardItems)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Category)
                .Include(x => x.Comments)
                .FirstOrDefaultAsync(expression);
        }

        public async Task<List<AppUser>> GetAppUsersByIncludeAsync()
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Carts)
                .ThenInclude(x => x.CardItems)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Category)
                .Include(x => x.Comments)
                .ToListAsync();
        }

        public async Task<List<AppUser>> GetAppUsersByIncludeAsync(Expression<Func<AppUser, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .Include(x => x.Carts)
                .ThenInclude(x => x.CardItems)
                .ThenInclude(x=> x.Product)
                .ThenInclude(x=> x.Category)
                .Include(x => x.Comments)
                .Where(expression)
                .ToListAsync();
        }
    }
}
