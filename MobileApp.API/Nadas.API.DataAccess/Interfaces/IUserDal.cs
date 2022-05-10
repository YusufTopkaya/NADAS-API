using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Interfaces
{
    public interface IUserDal : IGenericDal<User>
    {
        Task<User> LoginAsync(User user);
    }
}
