using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Interfaces;
using System.Linq.Expressions;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, IEntity, new()
    {
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using var context = new NadasContext();
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> FindById(int id)
        {
            using var context = new NadasContext();
            return await context.FindAsync<TEntity>(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using var context = new NadasContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity,TKey>> keySelector)
        {
            using var context = new NadasContext();
            return await context.Set<TEntity>().OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new NadasContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }
        public async Task<List<TEntity>> GetAllAsync<TKey>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TKey>> keySelector)
        {
            using var context = new NadasContext();
            return await context.Set<TEntity>().Where(filter).OrderByDescending(keySelector).ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new NadasContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task RemoveAsync(TEntity entity)
        {
            using var context = new NadasContext();
            context.Remove(entity);
            await context.SaveChangesAsync();

        }

        public async Task UpdateAsync(TEntity entity)
        {
            using var context = new NadasContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
