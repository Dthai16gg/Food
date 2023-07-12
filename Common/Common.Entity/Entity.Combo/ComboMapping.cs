using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Common.Common.Entity.Entity.Product;

namespace Common.Common.Entity.Entity.Combo;

public class ComboMapping
{
  public Guid Id { get; set; }
  [AllowNull]
  public Guid DrinkId { get; set; }
  [AllowNull]
  public Guid NormalFoodId { get; set; }
  [AllowNull]
  public Guid ComboId { get; set; }
  [Required]
  [Range(0, 100, ErrorMessage = "Quantity must be between 0 and 100")]
  public int Quantity { get; set; }
  public virtual PizzaProduct? PizzaProducts { get; set; }
  public virtual Drink? Drinks { get; set; }
  public virtual Combos? Combos { get; set; }
  public virtual NormalFood? NormalFoods { get; set; }

}
