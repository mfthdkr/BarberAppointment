using CoreLayer.DataAccess.Entities;

namespace CoreLayer.DataAccess.Repositories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class, BaseEntity
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAllAsNoTracking();

        Task AddAsync(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
