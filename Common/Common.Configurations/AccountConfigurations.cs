using Common.Common.Entity.Entity.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Common.Configurations;

public class AccountConfigurations : IEntityTypeConfiguration<Accounts>
{
  public void Configure(EntityTypeBuilder<Accounts> builder)
  {
    builder.ToTable("Accounts");
    builder.HasKey(x => x.Id);
    builder.HasOne(x => x.AuthorRoles)
        .WithMany(x => x.Accounts)
        .HasForeignKey(x => x.AuthorRoleId).HasConstraintName("FK_AuthorRoleId");
  }
}
