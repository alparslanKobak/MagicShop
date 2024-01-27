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
    public class HoroscopeService : Service<Horoscope>, IHoroscopeService
    {
        public HoroscopeService(DatabaseContext context) : base(context)
        {
        }

        public async Task<Horoscope> GetHoroscopeByIncludeAsync(Guid id)
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.BlogPosts)
              .ThenInclude(x => x.Comments)
              .ThenInclude(x => x.AppUser)
                 .FirstOrDefaultAsync(x => x.HoroscopeId == id);
        }

        public async Task<Horoscope> GetHoroscopeByIncludeAsync(Expression<Func<Horoscope, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.BlogPosts)
              .ThenInclude(x => x.Comments)
              .ThenInclude(x => x.AppUser)
                 .FirstOrDefaultAsync(expression);
        }

        public async Task<List<Horoscope>> GetHoroscopesByIncludeAsync()
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.BlogPosts)
              .ThenInclude(x => x.Comments)
              .ThenInclude(x => x.AppUser)
                 .ToListAsync();
        }

        public async Task<List<Horoscope>> GetHoroscopesByIncludeAsync(Expression<Func<Horoscope, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                 .Where(x => !x.IsDeleted)
                 .Include(x => x.BlogPosts)
              .ThenInclude(x => x.Comments)
              .ThenInclude(x => x.AppUser)
                 .Where(expression)
                 .ToListAsync();
        }
    }
}
