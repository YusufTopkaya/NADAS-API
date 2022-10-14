using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Concrete
{
    public class UserManager : GenericManager<User>, IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal, IGenericDal<User> genericDal) : base(genericDal) => _userDal = userDal;

        public async Task<User> LoginAsync(User user) => await _userDal.LoginAsync(user);

        public async Task<User> RegisterAsync(User user) => await _userDal.RegisterAsync(user);
    }
}
