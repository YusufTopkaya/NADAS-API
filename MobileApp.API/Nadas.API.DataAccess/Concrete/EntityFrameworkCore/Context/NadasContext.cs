using Microsoft.EntityFrameworkCore;
using Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class NadasContext : DbContext
    {
        public NadasContext(DbContextOptions<NadasContext> optionsBuilder):base(optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NadasContext).Assembly);
        }
        public override int SaveChanges()
        {
            Extensions.ChangeTrackerExtensions.SetAuditProperties(ChangeTracker);
            return base.SaveChanges();
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }

    }
}
