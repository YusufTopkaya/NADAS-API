using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Interfaces;
using System.Linq.Expressions;

namespace Nadas.API.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, IEntity, new()
    {

        private readonly IGenericDal<TEntity> _genericDal;

        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
           return await _genericDal.AddAsync(entity);
        }

        public async Task<TEntity> FindById(int id)
        {
            return await _genericDal.FindById(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _genericDal.GetAllAsync();
        }

        public async Task RemoveAsync(TEntity entity)
        {
            await  _genericDal.RemoveAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _genericDal.UpdateAsync(entity);
        }
    }
}
