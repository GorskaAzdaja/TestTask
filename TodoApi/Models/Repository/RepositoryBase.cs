using System.Linq.Expressions;
using TodoApi.Models.RepositoryInterface;

namespace TodoApi.Models.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DatabaseContext DatabaseContext { get; set; }

        public RepositoryBase(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
        }

        public IQueryable<T> FindAll()
        {
            return DatabaseContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return DatabaseContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            DatabaseContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            DatabaseContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            DatabaseContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            DatabaseContext.SaveChanges();
        }
    }
}
