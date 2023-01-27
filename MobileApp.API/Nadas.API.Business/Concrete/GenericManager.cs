using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Domain.Concrete;
using Nadas.API.Entities.Interfaces;
using System.Linq.Expressions;

namespace Nadas.API.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : EntityBase, new()
    {

        private readonly IGenericDal<TEntity> _genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
           return await _genericDal.AddAsync(entity);
        }

        public virtual async Task<TEntity> FindById(int id)
        {
            return await _genericDal.FindById(id);
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await _genericDal.GetAllAsync();
        }

        public virtual async Task RemoveAsync(TEntity entity)
        {
            await  _genericDal.RemoveAsync(entity);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await _genericDal.UpdateAsync(entity);
        }
    }
}
