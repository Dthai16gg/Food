using Common.Common.Entity.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class SizeConfiguration : IEntityTypeConfiguration<PizzaSize>
  {
    public void Configure(EntityTypeBuilder<PizzaSize> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_PizzaSize");
    }
  }
}
