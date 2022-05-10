using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Concrete
{
    public class ContentManager : GenericManager<Content>, IContentService
    {
        public ContentManager(IGenericDal<Content> genericDal) : base(genericDal)
        {

        }
    }
}
