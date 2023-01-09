using Nadas.API.Domain.Concrete;
using Nadas.API.Entities.Interfaces;

namespace Nadas.API.Entities.Concrete
{
    public class User : EntityBase , IEntity
    {
        public string FireBaseId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public bool? IsVerified { get; set; }
        public int? AuthLevel { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public IEnumerable<Answer> Answers { get; set; }

    }
}
