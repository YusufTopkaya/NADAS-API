using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Concrete
{
    public class AnswerManager : GenericManager<Answer>, IAnswerService
    {
        private readonly IAnswerDal _answerDal;

        public AnswerManager(IGenericDal<Answer> genericDal, IAnswerDal answerDal) : base(genericDal)
        {
            _answerDal = answerDal;
        }

        public Task<List<Answer>> GetAllByQuestionIdAsync(int id)
        {
            return _answerDal.GetAllByQuestionIdAsync(id);
        }

        public Task<List<Answer>> GetAllLoadedAsync()
        {
            return _answerDal.GetAllLoadedAsync();
        }
    }
}
