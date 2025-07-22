using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : Entity, new()
    where TContext : DbContext, new()

    {

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedState = context.Entry(entity);
                addedState.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedState = context.Entry(entity);
                deletedState.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedState = context.Entry(entity);
                updatedState.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public bool Any(Expression<Func<TEntity, bool>> filter)
        {
            using (var contexts = new TContext())
            {
                return contexts.Set<TEntity>().Any(filter);
            }
        }



        private TContext contextAsync = new TContext();
        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? await contextAsync.Set<TEntity>().ToListAsync()
                : await contextAsync.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await contextAsync.Set<TEntity>().SingleOrDefaultAsync(filter);
        }

        public async Task AddAsync(TEntity entity)
        {
            var addedState = contextAsync.Entry(entity);
            addedState.State = EntityState.Added;
            await contextAsync.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            var deletedState = contextAsync.Entry(entity);
            deletedState.State = EntityState.Deleted;
            await contextAsync.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            var updatedState = contextAsync.Entry(entity);
            updatedState.State = EntityState.Modified;
            await contextAsync.SaveChangesAsync();
        }


        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await contextAsync.Set<TEntity>().AnyAsync(filter);
        }




    }
}
