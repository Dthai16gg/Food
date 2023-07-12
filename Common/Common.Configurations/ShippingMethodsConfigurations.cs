using Common.Common.Entity.Entity.Delivery;
using Microsoft.EntityFrameworkCore;

namespace Common.Configurations
{
  public class ShippingMethodsConfigurations : IEntityTypeConfiguration<ShippingMethods>
  {
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ShippingMethods> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Name).IsRequired().HasMaxLength(30).HasColumnName("Name Shipping Methods");
    }
  }
}
