using Entities.Abstract;
using Repositories.Context;
using System.Linq.Expressions;

namespace Repositories.Abstract.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity, new()
    {

        public void Create(T entity)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();

            return filter is null
                ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();

        }

        public T GetById(int id)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            return context.Set<T>().Find(id);

        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();

            return context.Set<T>().FirstOrDefault(filter);

        }

        public void Update(T entity)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> expression)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            return context.Set<T>().Any(expression);
        }
    }
}
