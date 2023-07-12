using Common.Common.Entity.Entity.Oder;
using Microsoft.EntityFrameworkCore;

namespace Common.Configurations
{
  public class OrderDetailsConfigurations : IEntityTypeConfiguration<OderDetails>
  {
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OderDetails> builder)
    {
      builder.HasKey(x => x.Id);
      builder.HasOne(x => x.Oder).WithMany(x => x.OderDetails).HasForeignKey(x => x.OderId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
      builder.HasOne(x => x.Drink).WithMany(x => x.OderDetails).HasForeignKey(x => x.DrinkId).IsRequired(false);
      builder.HasOne(x => x.NormalFood).WithMany(x => x.OrderDetails).HasForeignKey(x => x.NormalFoodId).IsRequired(false);
      builder.HasOne(x => x.PizzaProduct).WithMany(x => x.OrderDetails).HasForeignKey(x => x.PizzaId).IsRequired(false);
      builder.HasOne(x => x.Combo).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ComboId).IsRequired(false);
    }
  }
}
