using Entities.Abstract;
using System.Linq.Expressions;

namespace Repositories.Abstract.Base
{
    public interface IBaseRepository<T> where T : class, IEntity, new()
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        T GetById(int id);
        T Get(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);
        bool Any(Expression<Func<T, bool>> expression);
    }
}
