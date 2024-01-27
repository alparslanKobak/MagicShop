using MagicShop.Kernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Process.Abstract
{
    public interface ICommentService : IService<Comment>
    {
        Task<List<Comment>> GetCommentsByIncludeAsync();
        Task<List<Comment>> GetCommentsByIncludeAsync(Expression<Func<Comment, bool>> expression);
        Task<Comment> GetCommentByIncludeAsync(Guid id);
        Task<Comment> GetCommentByIncludeAsync(Expression<Func<Comment, bool>> expression);
    }
}
