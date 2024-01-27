using MagicShop.Business;
using MagicShop.Kernel.Commons;
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
    public class Service<T> : IService<T> where T : class, ICommonProperty, new()
    {
        internal DatabaseContext _context;
        internal DbSet<T> _dbSet;

        public Service(DatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> FindAsync(Guid id)
        {

            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet
                .Where(x => !x.IsDeleted)
                .ToListAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
           
            return await _dbSet
                 .Where(x => !x.IsDeleted)
                .Where(expression).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AsNoTracking()
                .Where(x => !x.IsDeleted)
                .FirstOrDefaultAsync(expression);
        }

        public async Task<bool> SoftDeleteAsync(Guid id)
        {

            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
 
            entity.IsDeleted = true;
            //_context.Entry(entity).State = EntityState.Modified;


     
            var result = await _context.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateAsync(T entity, Guid id)
        {
            var entityToUpdate = await _dbSet.FindAsync(id);
            if (entityToUpdate == null)
            {
                return false;
            }
            _context.Entry(entityToUpdate).CurrentValues.SetValues(entity);
            _context.Entry(entityToUpdate).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
