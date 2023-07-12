using Common.Common.Entity.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class PizzaMappingConfiguration : IEntityTypeConfiguration<PriceMapping>
  {
    public void Configure(EntityTypeBuilder<PriceMapping> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_PriceMapping");
      builder.HasOne(x => x.PizzaPans).WithMany(x => x.PriceMappings).HasForeignKey(x => x.PizzaPanId).IsRequired(true).HasConstraintName("FK_PriceMapping_PizzaPan");
      builder.HasOne(x => x.PizzaSize).WithMany(x => x.PriceMappings).HasForeignKey(x => x.PizzaSizeId).IsRequired(true).HasConstraintName("FK_PriceMapping_PizzaSize");
      builder.HasOne(x => x.PizzaProducts).WithMany(x => x.PriceMappings).HasForeignKey(x => x.ProductId).IsRequired(true).HasConstraintName("FK_PriceMapping_PizzaProduct");
      builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
    }
  }
}
