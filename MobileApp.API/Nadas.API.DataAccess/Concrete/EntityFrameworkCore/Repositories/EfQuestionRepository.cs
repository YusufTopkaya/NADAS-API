using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context;
using Nadas.API.DataAccess.Interfaces;
using Nadas.API.Entities.Concrete;
using System.Security.Cryptography.X509Certificates;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfQuestionRepository : EfGenericRepository<Question>, IQuestionDal
    {
        public EfQuestionRepository(NadasContext context) : base(context)
        {
        }

        public async Task<List<Question>> GetAllLoadedAsync()
        {
            return await context.Questions
                .Where(x=>!x.IsDeleted)
                .Include(I => I.Answers)
                .Include(I => I.Content)
                .Include(I => I.User)
                .ToListAsync();
        }

        public override async Task<List<Question>> GetAllAsync()
        {
            return await context.Questions
                .Where(x => !x.IsDeleted)
                .Include(I=>I.Content)
                .Include(I=>I.User)
                .ToListAsync();
        }

    }
}
