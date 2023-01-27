using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Interfaces
{
    public interface IQuestionService : IGenericService<Question>
    {
        Task<List<Question>> GetAllLoadedAsync();

    }
}
