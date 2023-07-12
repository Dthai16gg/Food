using Common.Common.Entity.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class PanConfigurations : IEntityTypeConfiguration<PizzaPan>
  {
    public void Configure(EntityTypeBuilder<PizzaPan> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_PizzaPan");
    }
  }
}
