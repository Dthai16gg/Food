using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Common.Common.Entity.Entity.Combo;
using Common.Common.Entity.Entity.Product;
using Common.Common.Entity.Entity.Transaction;

namespace Common.Common.Entity.Entity.Oder;

public class OderDetails : IEntity.IEntity
{
    public Guid Id { get; set; }
    [AllowNull]
    public Guid ComboId { get; set; }
    [AllowNull]
    public Guid PizzaId { get; set; }
    [AllowNull]
    public Guid DrinkId { get; set; }
    public Guid OderId { get; set; }
    [AllowNull]
    public Guid NormalFoodId { get; set; }
    [Range(0,1000, ErrorMessage = "Quantity must be between 0 and 1000")]
    public int Quantity { get; set; }
    public virtual Combos? Combo { get; set; }
    public virtual Drink? Drink { get; set; }
    public virtual NormalFood? NormalFood { get; set; }
    public virtual Oder? Oder { get; set; }
    public virtual PizzaProduct? PizzaProduct { get; set; }
}