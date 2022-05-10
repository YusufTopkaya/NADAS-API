using Nadas.API.Domain.Concrete;
using Nadas.API.Entities.Interfaces;

namespace Nadas.API.Entities.Concrete
{
    public class User : EntityBase , IEntity
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsVerified { get; set; }
        public int? AuthLevel { get; set; }
    }
}
