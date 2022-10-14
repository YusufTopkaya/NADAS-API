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

        public Task<bool> FindByEmailAsync(string email)
        {
           return Task.FromResult(context.Users.Any(x => x.Email == email));
        }

        public async Task<User> LoginAsync(User user)
        {
            return await context.Set<User>().Where((p => (p.Email == user.Email) && (p.Password == user.Password))).FirstAsync();
        }

        public async Task<User> RegisterAsync(User user)
        {
            var result = await FindByEmailAsync(user.Email);
            if (!result)
             return await AddAsync(user);
            return null;
        }
    }
}
