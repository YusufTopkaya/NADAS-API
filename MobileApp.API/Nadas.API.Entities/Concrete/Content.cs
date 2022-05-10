using Nadas.API.Domain.Concrete;
using Nadas.API.Entities.Interfaces;

namespace Nadas.API.Entities.Concrete
{
    public class Content : EntityBase , IEntity
    {
        public string? Text { get; set; }
        //public int QuestionId { get; set; }
        //public Question Question { get; set; }
        //public List<string> MediaPaths { get; set; }
    }
}
