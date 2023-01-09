using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;
using System.Linq.Expressions;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User>, IUserDal
    {

        public EfUserRepository(NadasContext dbContext):base(dbContext)
        {
        }

        public async Task<User> RegisterAsync(User user)
        {
             return await AddAsync(user);
        }
    }
}
