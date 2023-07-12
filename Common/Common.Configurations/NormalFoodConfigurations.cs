using Common.Common.Entity.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class NormalFoodConfigurations : IEntityTypeConfiguration<NormalFood>
  {
    public void Configure(EntityTypeBuilder<NormalFood> builder)
    {
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
      builder.HasOne(x => x.Title).WithMany(x => x.NormalFoods).HasForeignKey(x => x.TitleId).IsRequired(false);
    }
  }
}
