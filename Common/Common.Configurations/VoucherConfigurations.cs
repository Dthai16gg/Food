using Common.Common.Entity.Entity.Transaction;
using Microsoft.EntityFrameworkCore;

namespace Common.Configurations
{
  public class VoucherConfigurations : IEntityTypeConfiguration<Voucher>
  {
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Voucher> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_Voucher");
    }
  }
}
