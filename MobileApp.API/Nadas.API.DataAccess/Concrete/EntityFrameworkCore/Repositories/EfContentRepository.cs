using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfContentRepository : EfGenericRepository<Content>, IContentDal
    {
        public EfContentRepository(NadasContext context) : base(context)
        {
        }
    }
}
