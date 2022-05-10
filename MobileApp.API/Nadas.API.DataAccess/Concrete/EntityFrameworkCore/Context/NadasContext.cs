using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class NadasContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=NadasDB; Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnswerMap());
            modelBuilder.ApplyConfiguration(new ContentMap());
            modelBuilder.ApplyConfiguration(new QuestionMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
