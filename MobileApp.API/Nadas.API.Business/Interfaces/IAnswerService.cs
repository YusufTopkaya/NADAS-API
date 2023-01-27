using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Interfaces
{
    public interface IAnswerService : IGenericService<Answer>
    {
        Task<List<Answer>> GetAllLoadedAsync();
        Task<List<Answer>> GetAllByQuestionIdAsync(int id);
        Task<Answer> AddAnswerAsync(Answer answer);
    }
}
