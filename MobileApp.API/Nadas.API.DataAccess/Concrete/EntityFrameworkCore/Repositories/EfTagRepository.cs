using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfTagRepository : EfGenericRepository<Tag>, ITagDal
    {

    }
}
