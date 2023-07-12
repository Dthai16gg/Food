using Common.Common.Entity.Entity.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Common.Configurations;

public class AuthorRoleConfigurations : IEntityTypeConfiguration<AuthorRole>
{
  public void Configure(EntityTypeBuilder<AuthorRole> builder)
  {
    builder.ToTable("Author Roles");
    builder.HasKey(x => x.Id);
    builder.Property(x => x.RoleName).HasMaxLength(20).IsRequired();
  }
}
