using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Interfaces
{
    public interface IAnswerDal : IGenericDal<Answer>
    {
        Task<List<Answer>> GetAllLoadedAsync();
        Task<List<Answer>> GetAllByQuestionIdAsync(int id);

    }
}
