using Common.Common.Entity.Entity.Combo;
using Common.Common.Entity.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class ComboMappingConfiguration : IEntityTypeConfiguration<ComboMapping>
  {
    public void Configure(EntityTypeBuilder<ComboMapping> builder)
    {
      builder.HasKey(x => x.Id);
      // builder.Property(x => x.Id).HasDefaultValueSql("NEWID()").HasColumnName("PK_ComboMapping");
      builder.HasOne(x => x.Combos).WithMany(x => x.ComboMappings).HasForeignKey(x => x.ComboId).IsRequired().OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_ComboId");
      builder.HasOne(x => x.PizzaProducts).WithMany(x => x.ComboMappings).HasForeignKey(x => x.ComboId).IsRequired(false).OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_ProductId");
      builder.HasOne(x => x.Drinks).WithMany(x => x.ComboMappings).HasForeignKey(x => x.DrinkId).IsRequired(false).OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_DrinkId");
      builder.HasOne(x => x.NormalFoods).WithMany(x => x.ComboMappings).HasForeignKey(x => x.NormalFoodId).IsRequired(false).OnDelete(DeleteBehavior.Restrict).HasConstraintName("FK_NormalFoodId");
    }
  }
}
