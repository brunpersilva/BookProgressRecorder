using System.Linq.Expressions;

namespace BookProgressRecorder.Repository.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task Add(TEntity entity);
        Task AddRange(IEnumerable<TEntity> enteties);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> enteties);
    }
}