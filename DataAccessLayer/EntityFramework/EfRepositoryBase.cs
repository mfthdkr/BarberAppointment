using CoreLayer.DataAccess.Entities;
using CoreLayer.DataAccess.Repositories;
using BarberAppointment.DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfRepositoryBase<TEntity>: IRepositoryBase<TEntity>where TEntity : class,BaseEntity
    {
        public EfRepositoryBase(BarberAppointmentContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            DbSet = Context.Set<TEntity>();
        }

        protected DbSet<TEntity> DbSet { get; set; }

        protected BarberAppointmentContext Context { get; set; }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet.Where(p => !p.IsDeleted);
        }

        // ChangeTracker'ı devre dışı bırakıyoruz.
        public IQueryable<TEntity> GetAllAsNoTracking()
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
