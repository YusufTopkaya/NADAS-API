using Nadas.API.Domain.Concrete;
using Nadas.API.Entities.Interfaces;

namespace Nadas.API.Entities.Concrete
{
    public class Answer : EntityBase , IEntity
    {
        public bool? IsVerified { get; set; }

        public int QuestionId { get; set; }
        public Question Question{ get; set; }

        public User? User { get; set; }
        public int UserId { get; set; }

        public int ContentId { get; set; }
        public Content Content { get; set; }
    }
}
