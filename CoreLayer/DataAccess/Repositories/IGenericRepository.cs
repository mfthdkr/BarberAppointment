using CoreLayer.DataAccess.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLayer.DataAccess.Repositories
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class,IDeletableEntity
    {
        IQueryable<TEntity> All();

        IQueryable<TEntity> AllAsNoTracking();

        Task AddAsync(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
