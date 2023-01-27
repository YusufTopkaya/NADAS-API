using Nadas.API.Domain.Concrete;
using Nadas.API.Entities.Interfaces;

namespace Nadas.API.Entities.Concrete
{
    public class Blog:EntityBase,IEntity
    {
        public string Title { get; set; }
        public string HTML { get; set; }
        public string Author { get; set; }

    }
}
