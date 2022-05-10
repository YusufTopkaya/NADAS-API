using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Concrete
{
    public class TagManager : GenericManager<Tag>, ITagService
    {
        public TagManager(IGenericDal<Tag> genericDal) : base(genericDal)
        {

        }
    }
}
