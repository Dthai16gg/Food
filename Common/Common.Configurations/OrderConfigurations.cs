using Common.Common.Entity.Entity.Oder;
using Microsoft.EntityFrameworkCore;

namespace Common.Configurations
{
  public class OrderConfigurations : IEntityTypeConfiguration<Oder>
  {
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Oder> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Id).HasColumnName("PK_Order");
      builder.HasOne(x => x.Accounts);
    }
  }
}
