using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> LoginAsync(User user);
        Task<User> RegisterAsync(User user);
    }

    
}