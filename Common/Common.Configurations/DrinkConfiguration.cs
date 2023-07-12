using Common.Common.Entity.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class DrinkConfiguration : IEntityTypeConfiguration<Drink>
  {
    public void Configure(EntityTypeBuilder<Drink> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_DrinkId");
      builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
      builder.HasOne(x => x.Title).WithMany(x => x.Drinks).HasForeignKey(x => x.TitleId).IsRequired(false);
    }
  }
}
