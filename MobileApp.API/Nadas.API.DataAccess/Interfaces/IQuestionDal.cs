using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Interfaces
{
    public interface IQuestionDal : IGenericDal<Question>
    {
        Task<List<Question>> GetAllLoadedAsync();
    }
}
