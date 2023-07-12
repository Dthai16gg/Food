using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Common.Common.Context
{
  public class CommonContext : DbContext
  {
    public CommonContext()
    {
    }

    public CommonContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=localhost,1433;Database=FastFood;User Id=SA;Password=Dthai16gg!;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    // DbSet
    public DbSet<Entity.Entity.Account.Accounts>? Accounts { get; set; }
    public DbSet<Entity.Entity.Account.AuthorRole>? AuthorRoles { get; set; }
    public DbSet<Entity.Entity.Combo.Combos>? Combos { get; set; }
    public DbSet<Entity.Entity.Combo.ComboMapping>? ComboMappings { get; set; }
    public DbSet<Entity.Entity.Delivery.ShippingMethods>? ShippingMethods { get; set; }
    public DbSet<Entity.Entity.Delivery.DeliveryDetails>? DeliveryDetails { get; set; }
    public DbSet<Entity.Entity.Oder.Oder>? Oder { get; set; }
    public DbSet<Entity.Entity.Oder.OderDetails>? OderDetails { get; set; }
    public DbSet<Entity.Entity.Product.Drink>? Drinks { get; set; }
    public DbSet<Entity.Entity.Product.NormalFood>? NormalFoods { get; set; }
    public DbSet<Entity.Entity.Product.PizzaProduct>? PizzaProducts { get; set; }
    public DbSet<Entity.Entity.Product.PizzaPan>? PizzaPans { get; set; }
    public DbSet<Entity.Entity.Product.PizzaSize>? PizzaSizes { get; set; }
    public DbSet<Entity.Entity.Product.PriceMapping>? PriceMappings { get; set; }
    public DbSet<Entity.Entity.Product.Title>? Titles { get; set; }
    public DbSet<Entity.Entity.Transaction.TransactionReport>? TransactionReports { get; set; }
    public DbSet<Entity.Entity.Transaction.PaymentMethods>? PaymentMethods { get; set; }
  }
}
