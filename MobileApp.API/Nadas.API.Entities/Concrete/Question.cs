using Nadas.API.Domain.Concrete;
using Nadas.API.Entities.Interfaces;

namespace Nadas.API.Entities.Concrete
{
    public class Question : EntityBase , IEntity
    {
        public string? Title { get; set; }
        public int? ViewCount { get; set; }
        public int? Rate { get; set; }

        public List<Answer>? Answers { get; set; }

        public List<Tag>? Tags { get; set; }

        public int? ContentId { get; set; }
        public Content? Content { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
