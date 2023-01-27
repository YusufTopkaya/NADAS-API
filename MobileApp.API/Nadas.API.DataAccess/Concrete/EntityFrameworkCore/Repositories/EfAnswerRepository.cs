using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAnswerRepository : EfGenericRepository<Answer>, IAnswerDal
    {
        public EfAnswerRepository(NadasContext context) : base(context)
        {
        }

        public async Task<List<Answer>> GetAllLoadedAsync()
        {
            return await context.Answers
                .Where(x=>!x.IsDeleted)
                .Include(I => I.Question)
                .Include(I => I.Content)
                .Include(I => I.User)
                .ToListAsync();
        }
        public async Task<List<Answer>> GetAllByQuestionIdAsync(int id)
        {
            return await context.Answers
                .Where(x => !x.IsDeleted)
                .Include(I => I.Question)
                .Include(I => I.Content)
                .Include(I => I.User)
                .Where(p=> p.QuestionId == id)
                .ToListAsync();
        }
    }
}
