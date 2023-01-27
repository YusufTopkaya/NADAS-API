using Nadas.API.Business.Interfaces;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.Business.Concrete
{
    public class QuestionManager : GenericManager<Question>, IQuestionService
    {
        private readonly IQuestionDal _questionDal;

        public QuestionManager(IGenericDal<Question> genericDal, IQuestionDal requestionDal) : base(genericDal)
        {
            _questionDal = requestionDal;
        }

        public override Task<List<Question>> GetAllAsync()
        {
            return _questionDal.GetAllAsync();
        }
        public async Task<List<Question>> GetAllLoadedAsync()
        {
            return await _questionDal.GetAllLoadedAsync();
        }
    }
}
