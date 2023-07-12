using Common.Common.Entity.Entity.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethods>
  {
    public void Configure(EntityTypeBuilder<PaymentMethods> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_PaymentMethods");
    }
  }
}
