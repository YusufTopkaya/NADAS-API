using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;
using System.Linq.Expressions;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfUserRepository : EfGenericRepository<User>, IUserDal
    {
        public async Task<User> LoginAsync(User user)
        {
            using var context = new NadasContext();
            return await context.Set<User>().Where((p => (p.Email == user.Email) && (p.Password == user.Password))).FirstAsync();
        }
    }
}
