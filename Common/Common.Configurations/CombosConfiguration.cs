using Microsoft.EntityFrameworkCore;
using Common.Common.Entity.Entity.Combo;
using Common.Common.Entity.Entity.Product;

namespace Common.Configurations
{
  public class CombosConfiguration : IEntityTypeConfiguration<Combos>
  {
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Combos> builder)
    {
      builder.ToTable("Combos");
      builder.HasKey(x => x.Id);
      //config decimal in fluent api
      builder.Property(x => x.TotalPrice).HasColumnType("decimal(18,2)");
      builder.Property(x => x.Name).IsRequired().HasMaxLength(30).HasColumnName("Name");
      builder.Property(x => x.Description).HasMaxLength(300).HasColumnName("Description");
      builder.HasOne(x => x.Title).WithMany(x => x.Combos).HasForeignKey(x => x.TitleId).IsRequired(false);
    }
  }
}
