using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Common.Common.Context;

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
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=FastFood;User Id=SA;Password=Dthai16gg!;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}