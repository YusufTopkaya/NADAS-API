using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAnswerRepository : EfGenericRepository<Answer>, IAnswerDal
    {
        public async Task<List<Answer>> GetAllLoadedAsync()
        {
            using var context = new NadasContext();
            return await context.Answers
                .Include(I => I.Question)
                .Include(I => I.Content)
                .Include(I => I.User)
                .ToListAsync();
        }
        public async Task<List<Answer>> GetAllByQuestionIdAsync(int id)
        {
            using var context = new NadasContext();
            return await context.Answers
                .Include(I => I.Question)
                .Include(I => I.Content)
                .Include(I => I.User)
                .Where(p=> p.QuestionId == id)
                .ToListAsync();
        }
    }
}
