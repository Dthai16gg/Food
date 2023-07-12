using Common.Common.Entity.Entity.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Configurations
{
  public class TitleConfigurations : IEntityTypeConfiguration<Title>
  {
    public void Configure(EntityTypeBuilder<Title> builder)
    {
      builder.HasKey(x => x.Id).HasName("PK_Title");
    }
  }
}
