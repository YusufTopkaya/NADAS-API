using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nadas.API.Entities.Concrete;

namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class ContentMap : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.CreationDate).HasDefaultValueSql("GETDATE()");
            builder.Property(I => I.UpdateDate).HasDefaultValueSql("GETDATE()");
            builder.Property(I => I.IsDeleted).HasDefaultValue(false);

            //builder.HasOne(I => I.Question).WithOne(I => I.Content).HasForeignKey<Question>(I=>I.Id).OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
