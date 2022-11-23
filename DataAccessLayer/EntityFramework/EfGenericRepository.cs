using CoreLayer.DataAccess.Entities;
using CoreLayer.DataAccess.Repositories;
using DataAccessLayer.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGenericRepository<TEntity>: IGenericRepository<TEntity>where TEntity : class,IDeletableEntity
    {
        public EfGenericRepository(ApplicationDbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            DbSet = Context.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet { get; set; }

        protected ApplicationDbContext Context { get; set; }

        public IQueryable<TEntity> All()
        {
            return DbSet.Where(p => !p.IsDeleted);
        }

        // ChangeTracker'ı devre dışı bırakıyoruz.
        public IQueryable<TEntity> AllAsNoTracking()
        {
            return DbSet.AsNoTracking().Where(p => !p.IsDeleted);
        }

        public Task AddAsync(TEntity entity)
        {
             return DbSet.AddAsync(entity).AsTask();
        }

        // ChangeTracker'dan izlenmyen dataların stateni Unchanged yapar.
        public void Update(TEntity entity)
        {   
            
            var entry = Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                // entity takip edilmyiorsa
                // State: Unchanged olur
                DbSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        // IsDeleted' i true ya çekip, DeletedOn tarihi atıyoruz. 
        public void Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.DeletedOn = DateTime.UtcNow;
            Update(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context?.Dispose();
            }
        }
    }
}
