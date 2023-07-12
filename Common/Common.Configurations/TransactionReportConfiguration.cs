using Common.Common.Entity.Entity.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class TransactionReportConfiguration : IEntityTypeConfiguration<TransactionReport>
  {
    public void Configure(EntityTypeBuilder<TransactionReport> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_TransactionReport");
      builder.HasOne(x => x.Accounts)
        .WithMany(x => x.TransactionReports)
        .HasForeignKey(x => x.UserId)
        .IsRequired(true)
        .HasConstraintName("FK_TransactionReport_Transaction")
        .OnDelete(DeleteBehavior.Restrict);
      builder.HasOne(x => x.DeliveryDetails)
        .WithMany(x => x.TransactionReports)
        .HasForeignKey(x => x.DeliveryDetailsId)
        .IsRequired(true)
        .HasConstraintName("FK_TransactionReport_OrderDetail")
        .OnDelete(DeleteBehavior.Restrict);
      builder.HasOne(x => x.PaymentMethods)
        .WithMany(x => x.TransactionReports)
        .HasForeignKey(x => x.PaymentMethodId)
        .IsRequired(true)
        .HasConstraintName("FK_TransactionReport_PaymentMethod")
        .OnDelete(DeleteBehavior.Restrict);
      builder.Property(x => x.TotalPrice).HasColumnType("decimal(18,2)");
    }
  }
}
