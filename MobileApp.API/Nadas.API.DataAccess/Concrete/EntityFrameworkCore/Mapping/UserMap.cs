using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nadas.API.Entities.Concrete;


namespace Nadas.API.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.CreatedUserId).HasDefaultValue(0);
            builder.Property(I => I.UpdatedUserId).HasDefaultValue(0);
            builder.Property(I => I.IsDeleted).HasDefaultValue(false);
            //builder.Property(I => I.Username).HasMaxLength(150).IsRequired();
            //builder.Property(I => I.Email).HasMaxLength(150).IsRequired();
            //builder.Property(I => I.Password).HasMaxLength(150).IsRequired();

            builder.Property(I => I.CreationDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(I => I.UpdateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(I => I.IsVerified).HasDefaultValue(false);
            builder.Property(I => I.AuthLevel).HasDefaultValue(0);
        }
    }
}
