using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfQuestionRepository : EfGenericRepository<Question>, IQuestionDal
    {
        public async Task<List<Question>> GetAllLoadedAsync()
        {
            using var context = new NadasContext();
            return await context.Questions
                .Include(I => I.Answers)
                .Include(I => I.Content)
                .Include(I => I.User)
                .ToListAsync();
        }
    }
}
