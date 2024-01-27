using MagicShop.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Abstract
{
    public interface IHoroscopeService : IService<Horoscope>
    {
        Task<List<Horoscope>> GetHoroscopesByIncludeAsync();
        Task<List<Horoscope>> GetHoroscopesByIncludeAsync(Expression<Func<Horoscope ,bool>> expression);
        Task<Horoscope> GetHoroscopeByIncludeAsync(Guid id);
        Task<Horoscope> GetHoroscopeByIncludeAsync(Expression<Func<Horoscope, bool>> expression);
    }
}
