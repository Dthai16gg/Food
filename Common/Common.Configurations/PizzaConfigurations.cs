using Common.Common.Entity.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class PizzaConfigurations : IEntityTypeConfiguration<PizzaProduct>
  {
    public void Configure(EntityTypeBuilder<PizzaProduct> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_PizzaProduct");
      builder.HasOne(x => x.Title).WithMany(x => x.PizzaProducts).HasForeignKey(x => x.TitleId).IsRequired(false);
    }
  }
}
