using Nadas.API.Entities.Interfaces;
using System.Linq.Expressions;

namespace Nadas.API.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> FindById(int id);
        Task<TEntity> AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);

    }
}
