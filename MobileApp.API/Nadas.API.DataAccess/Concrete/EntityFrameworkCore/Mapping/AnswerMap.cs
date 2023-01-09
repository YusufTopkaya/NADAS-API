using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AnswerMap : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.CreationDate).HasDefaultValueSql("GETDATE()");
            builder.Property(I => I.UpdateDate).HasDefaultValueSql("GETDATE()");
            builder.Property(I => I.IsDeleted).HasDefaultValue(false);

            builder.Property(I => I.IsVerified).HasDefaultValue(false);

            
        }
    }
}
