using Common.Common.Entity.Entity.Account;
using Common.Common.Entity.Entity.Delivery;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class DeliveryConfigurations : IEntityTypeConfiguration<DeliveryDetails>
  {
    public void Configure(EntityTypeBuilder<DeliveryDetails> builder)
    {
      builder.HasKey(x => x.Id);
      builder.HasOne<ShippingMethods>(x => x.ShippingMethods).WithMany(x => x.DeliveryDetails).HasForeignKey(x => x.ShippingMethodId).IsRequired(true).OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_ShippingMethodId");
      builder.HasOne(x => x.Accounts).WithMany(x => x.DeliveryDetails).HasForeignKey(x => x.UserId).IsRequired(true).OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_UserId");
    }
  }
}
