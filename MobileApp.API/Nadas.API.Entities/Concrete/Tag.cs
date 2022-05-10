using Nadas.API.Domain.Concrete;
using Nadas.API.Entities.Interfaces;

namespace Nadas.API.Entities.Concrete
{
    public class Tag : EntityBase , IEntity
    {
        public string? Name { get; set; }
        public List<Question> Questions { get; set; }
    }
}
